namespace CarBook.Aplication.Features.CQRS.Commands.BannerCommands
{
	public class CreateBannerByIdCommand(int Id)
	{
		public int Id { get; } = Id;
	}
}
