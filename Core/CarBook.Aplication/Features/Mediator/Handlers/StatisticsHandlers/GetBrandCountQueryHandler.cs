using CarBook.Aplication;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using BrandBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using MediatR;

namespace BrandBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetBrandCountQueryHandler(IStatisticsRepository repository) :
		IRequestHandler<GetBrandCountQuery, ServiceResult<GetBrandCountQueryResult>>
	{
		public async Task<ServiceResult<GetBrandCountQueryResult>> Handle(GetBrandCountQuery request, CancellationToken cancellationToken)
		{
			var BrandCount = await repository.GetBrandCountAsync();

			return ServiceResult<GetBrandCountQueryResult>.Success(new GetBrandCountQueryResult(BrandCount));

		}
	}
}
