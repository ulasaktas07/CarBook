using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.CarFeatureCommands
{
	public record UpdateCarFeatureAvailableChangeToFalseCommand:IRequest<ServiceResult>
	{
		public int Id { get; set; }

		public UpdateCarFeatureAvailableChangeToFalseCommand(int id)
		{
			Id = id;
		}
	}
}
