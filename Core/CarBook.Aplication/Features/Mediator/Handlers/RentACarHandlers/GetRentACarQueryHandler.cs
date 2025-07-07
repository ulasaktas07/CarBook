
using CarBook.Aplication.Features.Mediator.Queries.RentACarQueries;
using CarBook.Aplication.Features.Mediator.Results.RentACarResults;
using CarBook.Aplication.Interfaces.RentACarInterfaces;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.RentACarHandlers
{
	public class GetRentACarQueryHandler(IRentACarRepository rentACarRepository)
		: IRequestHandler<GetRentACarQuery, ServiceResult<List<GetRentACarQueryResult>>>
	{
		public async Task<ServiceResult<List<GetRentACarQueryResult>>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
		{
			var rentACars = await rentACarRepository.GetByFilterAsync(x =>x.LocationID == request.LocationID && x.Available);

			if (rentACars is null || !rentACars.Any())
			{
				return ServiceResult<List<GetRentACarQueryResult>>.Fail("Belirtilen kriterlere uygun araç bulunamadı.",HttpStatusCode.NotFound);
			}

			var queryResults = rentACars
				.Select(car => new GetRentACarQueryResult(car.CarID)).ToList();

			return ServiceResult<List<GetRentACarQueryResult>>.Success(queryResults);
		}
	}
}
