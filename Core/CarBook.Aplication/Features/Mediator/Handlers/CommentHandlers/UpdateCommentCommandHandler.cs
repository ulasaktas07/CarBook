using CarBook.Aplication.Features.Mediator.Commands.CommentCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.CommentHandlers
{
	public class UpdateCommentCommandHandler(IRepository<Comment> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<UpdateCommentCommand, ServiceResult>

	{
		public async Task<ServiceResult> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
		{
			var comment = await repository.GetByIdAsync(request.Id);
			if (comment == null || comment.Id != request.Id)
			{
				return ServiceResult.Fail("Comment not found", System.Net.HttpStatusCode.NotFound);
			}
			comment.Name = request.Name;
			comment.Description = request.Description;
			comment.Email = request.Email;
			comment.BlogID = request.BlogID;
			repository.Update(comment);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
