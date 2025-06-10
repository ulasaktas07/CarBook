namespace CarBook.Aplication.Features.Mediator.Commands.PricingCommands
{
	public record CreatePricingByIdCommand(int Id)
	{
		public int Id { get; init; } = Id;
	}
}
