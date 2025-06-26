using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.TestimonialCommands;
	public record CreateTestimonialCommand(string Name, string Title, string? Comment, string? ImageUrl)
	:IRequest<ServiceResult<CreateTestimonialByIdCommand>>;
