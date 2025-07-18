namespace CarBook.Aplication.Features.Mediator.Commands.ReviewCommands
{
	public record CreateReviewByIdCommand(int Id)
	{
		public int Id { get; init; } = Id;

	}
}
