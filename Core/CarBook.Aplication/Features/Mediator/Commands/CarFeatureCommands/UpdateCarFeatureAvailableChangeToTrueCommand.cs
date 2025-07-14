using MediatR;
namespace CarBook.Aplication.Features.Mediator.Commands.CarFeatureCommands
{
	public record UpdateCarFeatureAvailableChangeToTrueCommand : IRequest<ServiceResult>
	{
		public int Id { get; set; }

		public UpdateCarFeatureAvailableChangeToTrueCommand(int id)
		{
			Id = id;
		}
	}
	
}
