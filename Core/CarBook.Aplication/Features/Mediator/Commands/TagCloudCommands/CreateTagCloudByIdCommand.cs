namespace CarBook.Aplication.Features.Mediator.Commands.TagCloudCommands
{
	public record CreateTagCloudByIdCommand(int Id)
	{
		public int Id { get; } = Id;

	}
}
