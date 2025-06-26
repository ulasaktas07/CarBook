using MediatR;
namespace CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
	public record UpdateFeatureCommand(int Id, string Name):IRequest<ServiceResult>;
