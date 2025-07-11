using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetCarBrandAndModelByRentPriceDailyMinQueryHandler(IStatisticsRepository repository) :
		IRequestHandler<GetCarBrandAndModelByRentPriceDailyMinQuery, ServiceResult<GetCarBrandAndModelByRentPriceDailyMinQueryResult>>
	{
		public async Task<ServiceResult<GetCarBrandAndModelByRentPriceDailyMinQueryResult>> Handle(GetCarBrandAndModelByRentPriceDailyMinQuery request, CancellationToken cancellationToken)
		{
			var BrandCount = await repository.GetCarBrandAndModelByRentPriceDailyMinAsync();

			return ServiceResult<GetCarBrandAndModelByRentPriceDailyMinQueryResult>.
				Success(new GetCarBrandAndModelByRentPriceDailyMinQueryResult(BrandCount!));

		}
	}
}
