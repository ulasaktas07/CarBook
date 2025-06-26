namespace CarBook.Aplication.Features.CQRS.Commands.ContactCommands
{
	public record RemoveContactCommand
	{
		public int Id { get; }
		public RemoveContactCommand(int id)
		{
			Id = id;
		}
	}
}
