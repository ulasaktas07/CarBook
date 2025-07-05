using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetAvrgRentPriceForWeeklyQueryHandler(IStatisticsRepository statisticsRepository)
	: IRequestHandler<GetAvrgRentPriceForWeeklyQuery, ServiceResult<GetAvgPriceForWeeklyQueryResult>>
	{
		public async Task<ServiceResult<GetAvgPriceForWeeklyQueryResult>> Handle(GetAvrgRentPriceForWeeklyQuery request, CancellationToken cancellationToken)
		{
			var avrgRentPrice = await statisticsRepository.GetAvrgRentPriceForWeeklyAsync();

			return ServiceResult<GetAvgPriceForWeeklyQueryResult>.Success(new GetAvgPriceForWeeklyQueryResult(avrgRentPrice));
		}
	}
}
