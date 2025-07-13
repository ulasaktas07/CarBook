using CarBook.Aplication.Features.Mediator.Queries.CommentQueries;
using CarBook.Aplication.Features.Mediator.Results.CommentResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.CommentHandlers
{
	public class GetCommentByIdQueryHandler(IRepository<Comment> repository)
		: IRequestHandler<GetCommentByIdQuery, ServiceResult<GetCommentByIdQueryResult>>
	{
		public async Task<ServiceResult<GetCommentByIdQueryResult>> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
		{
			var comment = await repository.GetByIdAsync(request.Id);
			if (comment == null)
			{
				return ServiceResult<GetCommentByIdQueryResult>.Fail("Comment not found.", HttpStatusCode.NotFound);
			}
			var result = new GetCommentByIdQueryResult(comment.Id, comment.Name, comment.Description, comment.Email, comment.BlogID, comment.Created);
			return ServiceResult<GetCommentByIdQueryResult>.Success(result);
		}
	}
}
