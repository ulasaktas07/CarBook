namespace CarBook.Aplication.Features.CQRS.Commands.BannerCommands
{
	public record CreateBannerByIdCommand(int Id)
	{
		public int Id { get; } = Id;
	}
}
