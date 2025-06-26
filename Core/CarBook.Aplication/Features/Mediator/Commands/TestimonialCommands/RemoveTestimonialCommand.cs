using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.TestimonialCommands
{
	public record RemoveTestimonialCommand:IRequest<ServiceResult>
	{
		public int Id { get; init; }
		public RemoveTestimonialCommand(int id)
		{
			Id = id;
		}
	}
}
