namespace CarBook.Aplication.Features.CQRS.Commands.BrandCommands
{
	public record RemoveBrandCommand
	{
		public int Id { get; }
		public RemoveBrandCommand(int id)
		{
			Id = id;
		}
	}
}
