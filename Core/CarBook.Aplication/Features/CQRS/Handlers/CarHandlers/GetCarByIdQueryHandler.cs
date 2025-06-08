using CarBook.Aplication.Features.CQRS.Queries.CarQueries;
using CarBook.Aplication.Features.CQRS.Results.CarResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
	public class GetCarByIdQueryHandler(IRepository<Car> repository)
	{
		public async Task<ServiceResult<GetCarByIdQueryResult>> Handle(GetCarByIdQuery result)
		{
			var car = await repository.GetByIdAsync(result.Id);
			if (car == null) return ServiceResult<GetCarByIdQueryResult>.Fail("Araba bulunamadı", HttpStatusCode.NotFound);

			var carResult = new GetCarByIdQueryResult(car.Id,car.BrandID,car.Model,car.CoverImageUrl,car.Km,car.Seat,car.Lunggage,
				car.Fuel,car.BigImageUrl,car.Transmission);

			return ServiceResult<GetCarByIdQueryResult>.Success(carResult);
		}
	}
}
