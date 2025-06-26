using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.TagCloudCommands;
	public record CreateTagCloudCommand(string Title, int BlogID):IRequest<ServiceResult<CreateTagCloudByIdCommand>>;
