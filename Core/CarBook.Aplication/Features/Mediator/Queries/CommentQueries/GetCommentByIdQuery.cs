
using CarBook.Aplication.Features.Mediator.Results.BlogResults;
using CarBook.Aplication.Features.Mediator.Results.CommentResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.CommentQueries
{
	public record GetCommentByIdQuery : IRequest<ServiceResult<GetCommentByIdQueryResult>>
	{
		public int Id { get; set; }
		public GetCommentByIdQuery(int id)
		{
			Id = id;
		}
	}
}
