namespace CarBook.Aplication.Features.Mediator.Commands.TestimonialCommands
{
	public record CreateTestimonialByIdCommand(int Id)
	{

		public int Id { get; init; } = Id;
	}
}
