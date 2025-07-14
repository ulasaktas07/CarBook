

using CarBook.Aplication.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.CarFeatureInterfaces;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.CarFeatureHandlers
{
	public class UpdateCarFeatureAvailableChangeToFalseCommandHandler(ICarFeatureRepository repository,IUnitOfWork unitOfWork)
		: IRequestHandler<UpdateCarFeatureAvailableChangeToFalseCommand, ServiceResult>

	{
		public async Task<ServiceResult> Handle(UpdateCarFeatureAvailableChangeToFalseCommand request, CancellationToken cancellationToken)
		{
			var carFeature=await repository.ChangeCarFeatureAvailableToFalseAsync(request.Id);
			if (carFeature == null)
			{
				return ServiceResult.Fail("Araba özelliği bulunamadı.", HttpStatusCode.NotFound);
			}
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.OK);

		}
	}
}
