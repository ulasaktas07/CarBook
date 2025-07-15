using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.CarFeatureCommands;

public record CreateCarFeatureByCarCommand(int CarId, int FeatureId, bool Available) :IRequest<ServiceResult>;
