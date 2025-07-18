using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.ReviewCommands
{
	public class RemoveReviewCommand : IRequest<ServiceResult>
	{
		public int Id { get; init; }
		public RemoveReviewCommand(int id)
		{
			Id = id;
		}
	}
}
