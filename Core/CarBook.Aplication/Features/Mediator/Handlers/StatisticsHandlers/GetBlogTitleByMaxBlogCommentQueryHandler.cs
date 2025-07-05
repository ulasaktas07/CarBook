using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	internal class GetBlogTitleByMaxBlogCommentQueryHandler(IStatisticsRepository repository) :
		IRequestHandler<GetBlogTitleByMaxBlogCommentQuery, ServiceResult<GetBlogTitleByMaxBlogCommentQueryResult>>
	{
		public async Task<ServiceResult<GetBlogTitleByMaxBlogCommentQueryResult>> Handle(GetBlogTitleByMaxBlogCommentQuery request, CancellationToken cancellationToken)
		{
			var getBlogTitleByMaxBlogComment = await repository.GetBlogTitleByMaxBlogCommentAsync();

			return ServiceResult<GetBlogTitleByMaxBlogCommentQueryResult>.Success(new GetBlogTitleByMaxBlogCommentQueryResult(getBlogTitleByMaxBlogComment));

		}
	
	}
}
