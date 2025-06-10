using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommands;
	public record UpdateSocialMediaCommand(int Id, string Name, string Url, string? Icon):IRequest<ServiceResult>;
