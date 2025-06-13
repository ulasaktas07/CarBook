using MediatR;
namespace CarBook.Aplication.Features.Mediator.Commands.TestimonialCommands;
public record UpdateTestimonialCommand(int Id, string Name, string Title, string? Comment, string? ImageUrl):
	IRequest<ServiceResult>;
