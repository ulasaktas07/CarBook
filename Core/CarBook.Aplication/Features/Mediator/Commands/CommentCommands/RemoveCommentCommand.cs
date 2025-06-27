using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.CommentCommands
{
	public record RemoveCommentCommand:IRequest<ServiceResult>
	{
		public int Id { get; init; }
		public RemoveCommentCommand(int id)
		{
			Id = id;
		}
	}
}
