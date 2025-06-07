namespace CarBook.Aplication.Features.Commands.AboutCommands
{
	public record RemoveAboutCommand
	{
		public int Id { get; }
		public RemoveAboutCommand(int id)
		{
			Id = id;
		}
	}
}
