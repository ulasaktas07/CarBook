using CarBook.Aplication;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using LocationBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using MediatR;

namespace LocationBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetLocationCountQueryHandler(IStatisticsRepository repository) :
		IRequestHandler<GetLocationCountQuery, ServiceResult<GetLocationCountQueryResult>>
	{
		public async Task<ServiceResult<GetLocationCountQueryResult>> Handle(GetLocationCountQuery request, CancellationToken cancellationToken)
		{
			var LocationCount = await repository.GetLocationCountAsync();

			return ServiceResult<GetLocationCountQueryResult>.Success(new GetLocationCountQueryResult(LocationCount));

		}
	}
}
