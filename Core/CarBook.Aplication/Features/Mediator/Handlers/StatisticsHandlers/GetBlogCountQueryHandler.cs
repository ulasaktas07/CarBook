using CarBook.Aplication;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using BlogBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using MediatR;

namespace BlogBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetBlogCountQueryHandler(IStatisticsRepository repository) :
		IRequestHandler<GetBlogCountQuery, ServiceResult<GetBlogCountQueryResult>>
	{
		public async Task<ServiceResult<GetBlogCountQueryResult>> Handle(GetBlogCountQuery request, CancellationToken cancellationToken)
		{
			var BlogCount = await repository.GetBlogCountAsync();

			return ServiceResult<GetBlogCountQueryResult>.Success(new GetBlogCountQueryResult(BlogCount));

		}
	}
}
