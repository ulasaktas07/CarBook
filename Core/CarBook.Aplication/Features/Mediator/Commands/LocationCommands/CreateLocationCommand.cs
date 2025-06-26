using MediatR;
namespace CarBook.Aplication.Features.Mediator.Commands.LocationCommands;
public record CreateLocationCommand(string Name):IRequest<ServiceResult<CreateLocationByIdCommand>>;
