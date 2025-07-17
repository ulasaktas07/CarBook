using CarBook.Aplication.Features.CQRS.Queries.CarQueries;
using CarBook.Aplication.Features.CQRS.Results.CarResults;
using CarBook.Aplication.Interfaces.CarInterfaces;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
	public class GetCarByIdQueryHandler(ICarRepository repository)
	{
		public async Task<ServiceResult<GetCarByIdQueryResult>> Handle(GetCarByIdQuery result)
		{
			var car = await repository.GetCarsListWithBrands(result.Id);
			if (car == null) return ServiceResult<GetCarByIdQueryResult>.Fail("Araba bulunamadı", HttpStatusCode.NotFound);

			var carResult = new GetCarByIdQueryResult(car.Id,car.BrandID,car.Brand.Name,car.Model,car.CoverImageUrl,car.Km,car.Seat,car.Lunggage,
				car.Fuel,car.BigImageUrl,car.Transmission);

			return ServiceResult<GetCarByIdQueryResult>.Success(carResult);
		}
	}
}
