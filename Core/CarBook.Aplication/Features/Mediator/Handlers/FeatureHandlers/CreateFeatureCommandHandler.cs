using CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.FeatureHandlers
{
	public class CreateFeatureCommandHandler(IRepository<Feature> repository, IUnitOfWork unitOfWork) : 
		IRequestHandler<CreateFeatureCommand, ServiceResult<CreateFeatureByIdCommand>>
	{
		public async Task<ServiceResult<CreateFeatureByIdCommand>> Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
		{
			var feature = new Feature
			{
				Name = request.Name
			};
			var anyFeature = await repository.AnyAsync(x => x.Name == request.Name);
			if (anyFeature)
				return ServiceResult<CreateFeatureByIdCommand>.Fail("Bu isimde bir özellik zaten var.", HttpStatusCode.Conflict);

			await repository.CreateAsync(feature);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateFeatureByIdCommand>.SuccessAsCreated(new CreateFeatureByIdCommand(feature.Id), $"api/features/{feature.Id}");
		}
	}
}
