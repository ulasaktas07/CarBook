using CarBook.Aplication.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.CarFeatureInterfaces;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.CarFeatureHandlers
{
	public class UpdateCarFeatureAvailableChangeToTrueCommandHandler(ICarFeatureRepository repository, IUnitOfWork unitOfWork)
		: IRequestHandler<UpdateCarFeatureAvailableChangeToTrueCommand, ServiceResult>

	{
		public async Task<ServiceResult> Handle(UpdateCarFeatureAvailableChangeToTrueCommand request, CancellationToken cancellationToken)
		{
			var carFeature = await repository.ChangeCarFeatureAvailableToTrueAsync(request.Id);
			if (carFeature == null)
			{
				return ServiceResult.Fail("Araba özelliği bulunamadı.", HttpStatusCode.NotFound);
			}
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.OK);

		}
	}
}
