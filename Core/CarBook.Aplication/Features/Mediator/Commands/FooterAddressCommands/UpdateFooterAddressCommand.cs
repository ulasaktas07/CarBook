using MediatR;
namespace CarBook.Aplication.Features.Mediator.Commands.FooterAddressCommands;
	public record UpdateFooterAddressCommand(int Id, string Description, string Address, string Phone, string Email):
		IRequest<ServiceResult>;
