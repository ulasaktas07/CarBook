using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.CommentCommands;

public record CreateCommentCommad(string Name, string Description, string Email, int BlogID)
	: IRequest<ServiceResult<CreateCommentByIdCommand>>;
