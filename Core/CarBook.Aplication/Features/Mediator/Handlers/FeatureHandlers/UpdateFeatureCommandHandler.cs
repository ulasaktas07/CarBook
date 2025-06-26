using CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.FeatureHandlers
{
	public class UpdateFeatureCommandHandler(IRepository<Feature> repository, IUnitOfWork unitOfWork) :
		IRequestHandler<UpdateFeatureCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
		{
			var feature = await repository.GetByIdAsync(request.Id);
			if (feature == null || feature.Id != request.Id) return ServiceResult.Fail("Özellik bulunamadı", HttpStatusCode.NotFound);

			if (await repository.AnyAsync(x => x.Name == request.Name && x.Id != request.Id)) return ServiceResult.Fail("Bu isimde bir özellik zaten var", HttpStatusCode.Conflict);
			
			feature.Name = request.Name;
			repository.Update(feature);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
