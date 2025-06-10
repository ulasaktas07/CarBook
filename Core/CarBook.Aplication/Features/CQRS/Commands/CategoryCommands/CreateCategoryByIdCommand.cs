namespace CarBook.Aplication.Features.CQRS.Commands.CategoryCommands
{
	public record CreateCategoryByIdCommand(int Id)
	{
		public int Id { get; } = Id;

	}
}
