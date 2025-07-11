using CarBook.Aplication;
using CarBook.Aplication.Features.Mediator.Results.CarPricingResults;
using CarBook.Aplication.Interfaces.CarPricingInterfaces;
using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;

using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
	public class GetCarPricingWithCarQueryHandler
		: IRequestHandler<GetCarPricingWithCarQuery, ServiceResult<List<GetCarPricingWithCarQueryResult>>>
	{
		private readonly ICarPricingRepository _carPricingRepository;

		public GetCarPricingWithCarQueryHandler(ICarPricingRepository carPricingRepository)
		{
			_carPricingRepository = carPricingRepository;
		}

		public async Task<ServiceResult<List<GetCarPricingWithCarQueryResult>>> Handle(
			GetCarPricingWithCarQuery request,
			CancellationToken cancellationToken)
		{
			var carPricingList = await _carPricingRepository.GetCarPricingWithCars();

			var result = carPricingList.Select(carPricing => new GetCarPricingWithCarQueryResult(
				carPricing.Id,
				carPricing.CarId,
				carPricing.Car.Brand.Name,
				carPricing.Car.Model,
				carPricing.Price,
				carPricing.Car.CoverImageUrl
			)).ToList();

			return ServiceResult<List<GetCarPricingWithCarQueryResult>>.Success(result);
		}
	}
}
