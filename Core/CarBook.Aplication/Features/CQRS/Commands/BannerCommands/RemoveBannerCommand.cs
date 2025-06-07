namespace CarBook.Aplication.Features.CQRS.Commands.BannerCommands
{
	public record RemoveBannerCommand
	{
		public int Id { get; }
		public RemoveBannerCommand(int id)
		{
			Id = id;
		}
	}
}
