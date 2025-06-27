
namespace CarBook.Aplication.Features.Mediator.Commands.CommentCommands
{
	public record CreateCommentByIdCommand(int Id)
	{
		public int Id { get; init; } = Id;

	}
}
