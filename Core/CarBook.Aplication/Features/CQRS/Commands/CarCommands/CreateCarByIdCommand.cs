namespace CarBook.Aplication.Features.CQRS.Commands.CarCommands
{
	public record CreateCarByIdCommand(int Id)
	{
		public int Id { get; } = Id;

	}
}
