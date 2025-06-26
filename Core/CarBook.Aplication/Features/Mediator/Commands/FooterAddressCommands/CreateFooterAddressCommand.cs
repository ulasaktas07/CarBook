
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.FooterAddressCommands;
public record CreateFooterAddressCommand(string Description, string Address, string Phone, string Email) : IRequest<ServiceResult<CreateFooterAddressByIdCommand>>;