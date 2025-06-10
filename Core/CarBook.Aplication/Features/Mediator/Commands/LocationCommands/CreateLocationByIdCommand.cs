namespace CarBook.Aplication.Features.Mediator.Commands.LocationCommands
{
	public record CreateLocationByIdCommand(int Id)
	{
		public int Id { get; } = Id;
	}
}
