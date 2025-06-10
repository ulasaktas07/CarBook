using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.LocationCommands
{
	public record RemoveLocationCommand: IRequest<ServiceResult>
	{
		public int Id { get; }
		public RemoveLocationCommand(int id)
		{
			Id = id;
		}
	}
}
