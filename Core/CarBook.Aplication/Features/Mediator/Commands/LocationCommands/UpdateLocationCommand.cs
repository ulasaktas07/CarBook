using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.LocationCommands;
public record UpdateLocationCommand(int Id,string Name):IRequest<ServiceResult>;
