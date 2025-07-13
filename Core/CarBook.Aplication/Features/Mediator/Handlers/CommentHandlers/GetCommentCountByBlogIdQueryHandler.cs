using CarBook.Aplication.Features.Mediator.Queries.CommentQueries;
using CarBook.Aplication.Features.Mediator.Results.CommentResults;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.CommentInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.CommentHandlers
{
	public class GetCommentCountByBlogIdQueryHandler(ICommentRepository commentRepository)
		: IRequestHandler<GetCommentCountByBlogIdQuery, ServiceResult<GetCommentCountByBlogIdQueryResult>>
	{
		public async Task<ServiceResult<GetCommentCountByBlogIdQueryResult>> Handle(GetCommentCountByBlogIdQuery request, CancellationToken cancellationToken)
		{
			var count = await commentRepository.GetCommentCountByBlogId(request.BlogID);
			return ServiceResult<GetCommentCountByBlogIdQueryResult>.Success(new GetCommentCountByBlogIdQueryResult(count));

		}
	}
}