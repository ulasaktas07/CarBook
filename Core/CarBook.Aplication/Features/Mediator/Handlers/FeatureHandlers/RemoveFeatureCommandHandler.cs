
using CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.FeatureHandlers
{
	public class RemoveFeatureCommandHandler(IRepository<Feature> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<RemoveFeatureCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
		{
			var feature = await repository.GetByIdAsync(request.Id);

			repository.Remove(feature!);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
