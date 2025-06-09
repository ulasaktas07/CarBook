using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.FeatureCommands
{
	public class CreateFeatureByIdCommand(int Id) 
	{
		public int Id { get; } = Id;

	}
}
