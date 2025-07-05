using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetAvrgRentPriceForDailyQueryHandler(IStatisticsRepository statisticsRepository)
		: IRequestHandler<GetAvrgRentPriceForDailyQuery, ServiceResult<GetAvgPriceForDailyQueryResult>>
	{
		public async Task<ServiceResult<GetAvgPriceForDailyQueryResult>> Handle(GetAvrgRentPriceForDailyQuery request, CancellationToken cancellationToken)
		{
			var avrgRentPrice = await statisticsRepository.GetAvrgRentPriceForDailyAsync();

			return ServiceResult<GetAvgPriceForDailyQueryResult>.Success(new GetAvgPriceForDailyQueryResult(avrgRentPrice));
		}
	}
}
