using MediatR;
namespace CarBook.Aplication.Features.Mediator.Commands.PricingCommands;
public record CreatePricingCommand(string Name):IRequest<ServiceResult<CreatePricingByIdCommand>>;