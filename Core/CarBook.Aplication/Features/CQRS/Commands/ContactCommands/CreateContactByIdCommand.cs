namespace CarBook.Aplication.Features.CQRS.Commands.ContactCommands
{
	public record CreateContactByIdCommand(int Id)
	{
		public int Id { get; } = Id;

	}
}
