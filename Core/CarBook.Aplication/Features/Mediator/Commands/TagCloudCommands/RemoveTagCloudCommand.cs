using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.TagCloudCommands
{
	public record RemoveTagCloudCommand:IRequest<ServiceResult>
	{
		public int Id { get; }
		public RemoveTagCloudCommand(int id)
		{
			Id = id;
		}
	}
}
