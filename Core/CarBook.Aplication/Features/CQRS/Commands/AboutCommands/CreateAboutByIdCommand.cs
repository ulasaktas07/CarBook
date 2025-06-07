namespace CarBook.Aplication.Features.CQRS.Commands.AboutCommands
{
	public class CreateAboutByIdCommand(int Id)
	{
		public int Id { get; } = Id;
	}
}
