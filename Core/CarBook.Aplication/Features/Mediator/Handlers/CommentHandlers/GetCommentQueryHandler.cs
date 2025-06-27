using CarBook.Aplication.Features.Mediator.Queries.CommentQueries;
using CarBook.Aplication.Features.Mediator.Results.CommentResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.CommentHandlers
{
	public class GetCommentQueryHandler(IRepository<Comment> repository)
		: IRequestHandler<GetCommentQuery, ServiceResult<List<GetCommentQueryResult>>>
	{
		public async Task<ServiceResult<List<GetCommentQueryResult>>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
		{
			var comments = await repository.GetAllAsync();
			if (comments == null || !comments.Any())
			{
				return ServiceResult<List<GetCommentQueryResult>>.Fail("No comments found.",HttpStatusCode.NotFound);
			}
			var result=comments.Select(comments => new GetCommentQueryResult(comments.Id,comments.Name,
				comments.Description,comments.BlogID,comments.Created)).ToList();
			return ServiceResult<List<GetCommentQueryResult>>.Success(result);
		}
	}

}
