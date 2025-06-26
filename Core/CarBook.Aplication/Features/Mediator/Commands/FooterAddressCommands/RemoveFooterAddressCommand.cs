using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.FooterAddressCommands
{
	public record RemoveFooterAddressCommand : IRequest<ServiceResult>
	{
		public int Id { get; }

		public RemoveFooterAddressCommand(int id)
		{
			Id = id;
		}
	}
}
