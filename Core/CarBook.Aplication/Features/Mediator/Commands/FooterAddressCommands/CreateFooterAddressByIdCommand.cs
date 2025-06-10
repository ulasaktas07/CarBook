namespace CarBook.Aplication.Features.Mediator.Commands.FooterAddressCommands
{
	public record CreateFooterAddressByIdCommand(int Id) 
	{
		public int Id { get; } = Id;
	}
}
