namespace CarBook.Aplication.Features.Mediator.Commands.BlogCommands
{
	public record CreateBlogByIdCommand(int Id)
	{
		public int Id { get; init; } = Id;
	}
}
