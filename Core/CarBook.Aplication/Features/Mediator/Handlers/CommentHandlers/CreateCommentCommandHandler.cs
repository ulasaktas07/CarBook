
using CarBook.Aplication.Features.Mediator.Commands.BlogCommands;
using CarBook.Aplication.Features.Mediator.Commands.CommentCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Reflection.Metadata;

namespace CarBook.Aplication.Features.Mediator.Handlers.CommentHandlers
{
	public class CreateCommentCommandHandler(IRepository<Comment> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<CreateCommentCommad, ServiceResult<CreateCommentByIdCommand>>
	{
		public async Task<ServiceResult<CreateCommentByIdCommand>> Handle(CreateCommentCommad request, CancellationToken cancellationToken)
		{
			var comment = new Comment
			{
				Name = request.Name,
				Description = request.Description,
				BlogID = request.BlogID,
			};
			await repository.CreateAsync(comment);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateCommentByIdCommand>.SuccessAsCreated(new CreateCommentByIdCommand(comment.Id), $"api/comments/{comment.Id}");
		}
	}
}
