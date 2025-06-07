namespace CarBook.Aplication.Features.CQRS.Commands.BrandCommands
{
	public class CreateBrandByIdCommand(int Id)
	{
		public int Id { get; } = Id;
	}
}
