using MediatR;
namespace CarBook.Aplication.Features.Mediator.Commands.ServiceCommands;
public record UpdateServiceCommand(int Id, string Title, string? Description, string? IconUrl) :IRequest<ServiceResult>;
