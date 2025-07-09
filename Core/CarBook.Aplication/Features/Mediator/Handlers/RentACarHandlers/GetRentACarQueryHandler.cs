
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
			var rentACars = await rentACarRepository.GetByFilterAsync
				(x => x.LocationID == request.LocationID && x.Available == request.Available);

			if (rentACars is null || !rentACars.Any())
			{
				return ServiceResult<List<GetRentACarQueryResult>>.Fail("Belirtilen kriterlere uygun araç bulunamadı.", HttpStatusCode.NotFound);
			}


			var queryResults = rentACars.Select(car => new GetRentACarQueryResult(car.CarID,
		car.Car?.Brand?.Name ?? "Bilinmiyor", // Marka varsa al, yoksa fallback
		car.Car?.Model ?? "Model Bilinmiyor",
		car.Car?.CarPricings?.FirstOrDefault()?.Price ?? 0, // Fiyat varsa al, yoksa 0
		car.Car?.CoverImageUrl ?? "")).ToList();

			return ServiceResult<List<GetRentACarQueryResult>>.Success(queryResults);
		}
	}
}
