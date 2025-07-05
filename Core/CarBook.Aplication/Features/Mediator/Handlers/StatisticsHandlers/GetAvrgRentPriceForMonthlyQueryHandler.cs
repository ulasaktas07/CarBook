using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetAvrgRentPriceForMonthlyQueryHandler(IStatisticsRepository statisticsRepository)
	: IRequestHandler<GetAvrgRentPriceForMonthlyQuery, ServiceResult<GetAvgPriceForMonthlyQueryResult>>
	{
		public async Task<ServiceResult<GetAvgPriceForMonthlyQueryResult>> Handle(GetAvrgRentPriceForMonthlyQuery request, CancellationToken cancellationToken)
		{
			var avrgRentPrice = await statisticsRepository.GetAvrgRentPriceForMonthlyAsync();

			return ServiceResult<GetAvgPriceForMonthlyQueryResult>.Success(new GetAvgPriceForMonthlyQueryResult(avrgRentPrice));
		}
	}
}
