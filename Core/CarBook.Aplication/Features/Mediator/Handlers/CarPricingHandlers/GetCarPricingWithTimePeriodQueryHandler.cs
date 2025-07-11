using CarBook.Aplication.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Aplication.Features.Mediator.Results.CarPricingResults;
using CarBook.Aplication.Interfaces.CarPricingInterfaces;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.CarPricingHandlers
{
	public class GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository repository)
		: IRequestHandler<GetCarPricingWithTimePeriodQuery, ServiceResult<List<GetCarPricingWithTimePeriodQueryResult>>>
	{
		public async Task<ServiceResult<List<GetCarPricingWithTimePeriodQueryResult>>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
		{
			var carPricing = await repository.GetCarPricingWithTimePeriod();
			if (carPricing == null || !carPricing.Any())
			{
				return ServiceResult<List<GetCarPricingWithTimePeriodQueryResult>>
					.Fail("Belirtilen zaman aralığı için araç fiyatlandırma verisi bulunamadı.", HttpStatusCode.NotFound);
			}
			var result = carPricing.Select(cp => new GetCarPricingWithTimePeriodQueryResult
			{
				Model = cp.Model,
				DailyPrice = cp.Amounts[0],  // Assuming the first amount is daily
				WeeklyPrice = cp.Amounts[1], // Assuming the second amount is weekly
				MonthlyPrice = cp.Amounts[2] // Assuming the third amount is monthly

			}).ToList();
			return ServiceResult<List<GetCarPricingWithTimePeriodQueryResult>>.Success(result);
		}
	}
}
