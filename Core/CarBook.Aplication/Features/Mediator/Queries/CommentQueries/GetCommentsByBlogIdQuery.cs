using CarBook.Aplication.Features.Mediator.Results.CommentResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.CommentQueries;

public record GetCommentsByBlogIdQuery :IRequest<ServiceResult<List<GetCommentsByBlogIdQueryResult>>>
{
	public int Id { get; set; }

	public GetCommentsByBlogIdQuery(int id)
	{
		Id = id;
	}
}
