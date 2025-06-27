using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.CommentCommands;

public record CreateCommentCommad(string Name, string Description, int BlogID)
	: IRequest<ServiceResult<CreateCommentByIdCommand>>;
