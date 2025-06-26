using CarBook.Aplication.Features.CQRS.Results.CarResults;
using CarBook.Aplication.Interfaces.CarInterfaces;

namespace CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
	public class GetLas5CarsWithBrandQueryHandler(ICarRepository repository)
	{
		public ServiceResult<List<GetLast5CarsWithBrandQueryResult>> Handle()
		{
			var cars =  repository.GetCarsLast5WithBrands();
			var values = cars.Select(car => new GetLast5CarsWithBrandQueryResult(car.Id, car.BrandID, car.Brand.Name, car.Model, car.CoverImageUrl, car.Km, car.Seat, car.Lunggage,
				car.Fuel, car.BigImageUrl, car.Transmission)).ToList();

			return ServiceResult<List<GetLast5CarsWithBrandQueryResult>>.Success(values);
		}
	}
}
