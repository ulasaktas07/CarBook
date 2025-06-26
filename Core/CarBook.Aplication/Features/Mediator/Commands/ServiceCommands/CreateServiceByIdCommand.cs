namespace CarBook.Aplication.Features.Mediator.Commands.ServiceCommands;
public record CreateServiceByIdCommand(int Id)
{
	public int Id { get; init; } = Id;
}
