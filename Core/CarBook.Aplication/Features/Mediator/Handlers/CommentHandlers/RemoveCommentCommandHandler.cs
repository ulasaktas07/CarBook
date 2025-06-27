using CarBook.Aplication.Features.Mediator.Commands.CommentCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.CommentHandlers
{
	public class RemoveCommentCommandHandler(IRepository<Comment> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<RemoveCommentCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(RemoveCommentCommand request, CancellationToken cancellationToken)
		{
			var comment = await repository.GetByIdAsync(request.Id);
			if (comment == null || comment.Id != request.Id)
			{
				return ServiceResult.Fail("Comment not found", HttpStatusCode.NotFound);
			}
			repository.Remove(comment);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
