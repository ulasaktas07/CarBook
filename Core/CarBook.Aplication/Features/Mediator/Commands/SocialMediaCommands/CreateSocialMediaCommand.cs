using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommands;
	public record CreateSocialMediaCommand(string Name, string Url, string? Icon):IRequest<ServiceResult<CreateSocialMediaByIdCommand>>;