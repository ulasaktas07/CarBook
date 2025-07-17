using CarBook.Aplication.Features.Mediator.Queries.CarDescriptionQueries;
using CarBook.Aplication.Features.Mediator.Results.CarDescriptionResults;
using CarBook.Aplication.Interfaces.CarDescriptionInterfaces;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.CarDescriptionHandlers
{
	public class GetCarDescriptionQueryHandler(ICarDescriptionRepository repository) : IRequestHandler<GetCarDescriptionQuery, ServiceResult<GetCarDescriptionQueryResult>>
	{
		public async Task<ServiceResult<GetCarDescriptionQueryResult>> Handle(GetCarDescriptionQuery request, CancellationToken cancellationToken)
		{
			var carDescription = await repository.CarDescriptionGetByCarIdAsync(request.Id);
			if (carDescription == null)
			{
				return ServiceResult<GetCarDescriptionQueryResult>.Fail("Araba açıklaması bulunamadı.",HttpStatusCode.NotFound);
			}
			var result = new GetCarDescriptionQueryResult(carDescription.Id, carDescription.CarId, carDescription.Details);
			return ServiceResult<GetCarDescriptionQueryResult>.Success(result);
		}
	}
}
