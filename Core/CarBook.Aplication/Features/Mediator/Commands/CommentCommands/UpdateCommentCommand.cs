using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.CommentCommands;
public record UpdateCommentCommand(int Id, string Name, string Description, int BlogID)
	:IRequest<ServiceResult>;
