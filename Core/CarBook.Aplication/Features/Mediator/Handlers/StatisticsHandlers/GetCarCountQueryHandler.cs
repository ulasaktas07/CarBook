using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetCarCountQueryHandler(IStatisticsRepository repository) : IRequestHandler<GetCarCountQuery, ServiceResult<GetCarCountQueryResult>>
	{
		public  async Task<ServiceResult<GetCarCountQueryResult>> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
		{
			var carCount = await repository.GetCarCountAsync();

			return ServiceResult<GetCarCountQueryResult>.Success(new GetCarCountQueryResult(carCount));

		}
	}
}
