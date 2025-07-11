namespace CarBook.Aplication.Features.Mediator.Commands.ReservationCommands;

public record CreateResertationByIdCommand(int Id)
{
	public int Id { get; init; } = Id;
}
