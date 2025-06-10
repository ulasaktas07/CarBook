namespace CarBook.Aplication.Features.CQRS.Commands.BrandCommands
{
	public record CreateBrandByIdCommand(int Id)
	{
		public int Id { get; } = Id;
	}
}
