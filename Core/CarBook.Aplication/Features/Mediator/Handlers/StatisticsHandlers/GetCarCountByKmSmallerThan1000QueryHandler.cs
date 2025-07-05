using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetCarCountByKmSmallerThan1000QueryHandler(IStatisticsRepository repository) :
		IRequestHandler<GetCarCountByKmSmallerThan1000Query, ServiceResult<GetCarCountByKmSmallerThan1000QueryResult>>
	{
		public async Task<ServiceResult<GetCarCountByKmSmallerThan1000QueryResult>> Handle(GetCarCountByKmSmallerThan1000Query request, CancellationToken cancellationToken)
		{
			var getCarCountByKmSmallerThan1000 = await repository.GetCarCountByKmSmallerThan1000Async();

			return ServiceResult<GetCarCountByKmSmallerThan1000QueryResult>.Success(new GetCarCountByKmSmallerThan1000QueryResult(getCarCountByKmSmallerThan1000));

		}
	
	}
}
