namespace CarBook.Aplication.Features.CQRS.Commands.CategoryCommands
{
	public class CreateCategoryByIdCommand(int Id)
	{
		public int Id { get; } = Id;

	}
}
