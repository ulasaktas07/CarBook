using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetCarBrandAndModelByRentPriceDailyMaxQueryHandler(IStatisticsRepository repository) :
		IRequestHandler< GetCarBrandAndModelByRentPriceDailyMaxQuery, ServiceResult< GetCarBrandAndModelByRentPriceDailyMaxQueryResult>>
	{
		public async Task<ServiceResult< GetCarBrandAndModelByRentPriceDailyMaxQueryResult>> Handle( GetCarBrandAndModelByRentPriceDailyMaxQuery request, CancellationToken cancellationToken)
		{
			var getCarBrandAndModelByRentPriceDailyMax = await repository. GetCarBrandAndModelByRentPriceDailyMaxAsync();

			return ServiceResult< GetCarBrandAndModelByRentPriceDailyMaxQueryResult>.
				Success(new  GetCarBrandAndModelByRentPriceDailyMaxQueryResult(getCarBrandAndModelByRentPriceDailyMax!));

		}
	
	}
}
