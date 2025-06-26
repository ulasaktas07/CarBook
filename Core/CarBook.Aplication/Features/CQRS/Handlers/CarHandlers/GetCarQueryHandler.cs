using CarBook.Aplication.Features.CQRS.Results.CarResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
	public class GetCarQueryHandler(IRepository<Car> repository)
	{
		public async Task<ServiceResult<List<GetCarQueryResult>>> Handle()
		{
			var cars = await repository.GetAllAsync();
			var values = cars.Select(car => new GetCarQueryResult(car.Id,car.BrandID,car.Model,car.CoverImageUrl,car.Km,car.Seat,car.Lunggage,
				car.Fuel,car.BigImageUrl,car.Transmission)).ToList();
	
			return ServiceResult<List<GetCarQueryResult>>.Success(values);
		}
	}
}
