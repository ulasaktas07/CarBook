using CarBook.Aplication.Features.Mediator.Queries.CommentQueries;
using CarBook.Aplication.Features.Mediator.Results.CommentResults;
using CarBook.Aplication.Interfaces.CommentInterfaces;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.CommentHandlers
{
	public class GetCommentsByBlogIdQueryHandler(ICommentRepository commentRepository)
		: IRequestHandler<GetCommentsByBlogIdQuery, ServiceResult<List<GetCommentsByBlogIdQueryResult>>>
	{
		public async Task<ServiceResult<List<GetCommentsByBlogIdQueryResult>>> Handle(GetCommentsByBlogIdQuery request, CancellationToken cancellationToken)
		{
			var comments = await commentRepository.GetCommentsByBlogId(request.Id);
			if (comments == null || !comments.Any())
			{
				return ServiceResult<List<GetCommentsByBlogIdQueryResult>>.Fail("Bu blogda yorum yok.",HttpStatusCode.NotFound);
			}
			var result = comments.Select(c => new GetCommentsByBlogIdQueryResult(c.Id,c.Name,c.Description,c.BlogID,c.Created)).ToList();
			return ServiceResult<List<GetCommentsByBlogIdQueryResult>>.Success(result);
		}
	}
}
