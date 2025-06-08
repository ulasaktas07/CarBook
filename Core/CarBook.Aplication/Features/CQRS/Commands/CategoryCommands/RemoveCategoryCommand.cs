namespace CarBook.Aplication.Features.CQRS.Commands.CategoryCommands
{
	public record RemoveCategoryCommand
	{
		public int Id { get; }
		public RemoveCategoryCommand(int id)
		{
			Id = id;
		}
	}
}

