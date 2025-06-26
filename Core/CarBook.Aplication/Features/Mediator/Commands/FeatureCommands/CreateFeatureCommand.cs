using MediatR;
namespace CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
	public record CreateFeatureCommand(string Name):IRequest<ServiceResult<CreateFeatureByIdCommand>>;
