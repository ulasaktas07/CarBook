namespace CarBook.Aplication.Features.CQRS.Commands.AboutCommands
{
	public record CreateAboutByIdCommand(int Id)
	{
		public int Id { get; } = Id;
	}
}
