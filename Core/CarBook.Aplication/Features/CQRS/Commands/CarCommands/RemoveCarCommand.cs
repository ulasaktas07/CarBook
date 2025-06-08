namespace CarBook.Aplication.Features.CQRS.Commands.CarCommands
{
	public record RemoveCarCommand
	{
		public int Id { get; }
		public RemoveCarCommand(int id)
		{
			Id = id;
		}
	}
}
