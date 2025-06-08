namespace CarBook.Aplication.Features.CQRS.Commands.CarCommands
{
	public class CreateCarByIdCommand(int Id)
	{
		public int Id { get; } = Id;

	}
}
