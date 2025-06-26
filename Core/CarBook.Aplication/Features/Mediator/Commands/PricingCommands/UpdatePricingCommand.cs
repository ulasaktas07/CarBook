using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.PricingCommands;
public record UpdatePricingCommand(int Id,string Name):IRequest<ServiceResult>;
