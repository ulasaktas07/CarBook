namespace CarBook.Aplication.Features.Mediator.Commands.AppUserCommands
{
	public record CreateAppUserByIdCommand(int Id)
	{
		public int Id { get; init; } = Id;

	}
}
