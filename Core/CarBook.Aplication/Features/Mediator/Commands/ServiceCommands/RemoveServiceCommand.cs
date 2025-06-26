using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.ServiceCommands;
public record RemoveServiceCommand:IRequest<ServiceResult>
{
	public int Id { get; init; }
	public RemoveServiceCommand(int id)
	{
		Id = id;
	}
}
