namespace CarBook.Aplication.Features.Mediator.Commands.FeatureCommands
{
	public record CreateFeatureByIdCommand(int Id) 
	{
		public int Id { get; } = Id;

	}
}
