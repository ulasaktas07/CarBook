namespace CarBook.Aplication.Features.Mediator.Commands.WriterCommands
{
	public record CreateWriterByIdCommand(int Id)
	{
		public int Id { get; init; } = Id;
	}
}
