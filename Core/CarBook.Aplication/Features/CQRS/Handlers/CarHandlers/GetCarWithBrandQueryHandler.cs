using CarBook.Aplication.Features.CQRS.Results.CarResults;
using CarBook.Aplication.Interfaces.CarInterfaces;

namespace CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
	public class GetCarWithBrandQueryHandler(ICarRepository repository)
	{
		public ServiceResult<List<GetCarWithBrandQueryResult>> Handle()
		{
			var cars =  repository.GetCarsListWithBrands();
			var values = cars.Select(car => new GetCarWithBrandQueryResult(car.Id, car.BrandID, car.Brand.Name, car.Model, car.CoverImageUrl, car.Km, car.Seat, car.Lunggage,
				car.Fuel, car.BigImageUrl, car.Transmission)).ToList();

			return ServiceResult<List<GetCarWithBrandQueryResult>>.Success(values);
		}
	}
}
