using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.ReviewCommands;

public record CreateReviewCommand
	(string CustomerName, string? CustomerImage, string Comment, int RaytingValue, int CarID)
	: IRequest<ServiceResult<CreateReviewByIdCommand>>;
