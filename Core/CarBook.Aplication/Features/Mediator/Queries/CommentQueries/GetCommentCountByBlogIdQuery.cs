using CarBook.Aplication.Features.Mediator.Results.CommentResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.CommentQueries;

public record GetCommentCountByBlogIdQuery :IRequest<ServiceResult<GetCommentCountByBlogIdQueryResult>>
	{
	public int BlogID { get; set; } 
	public GetCommentCountByBlogIdQuery(int blogID)
	{
		BlogID = blogID;
	}
}
