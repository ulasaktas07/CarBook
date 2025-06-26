using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.TagCloudCommands;
public record UpdateTagCloudCommand(int Id, string Title, int BlogID):IRequest<ServiceResult>;
