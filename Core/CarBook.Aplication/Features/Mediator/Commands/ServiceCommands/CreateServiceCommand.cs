using MediatR;
namespace CarBook.Aplication.Features.Mediator.Commands.ServiceCommands;
public record CreateServiceCommand(string Title, string? Description, string? IconUrl) : IRequest<ServiceResult<CreateServiceByIdCommand>>;
