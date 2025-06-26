using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.FeatureCommands
{
	public record RemoveFeatureCommand:IRequest<ServiceResult>
	{
		public int Id { get; }
		public RemoveFeatureCommand(int id)
		{
			Id = id;
		}
	}
}
