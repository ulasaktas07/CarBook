using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.PricingCommands
{
	public record RemovePricingCommand:IRequest<ServiceResult>
	{
		public int Id { get; }
		public RemovePricingCommand(int id)
		{
			Id = id;
		}
	}
}
