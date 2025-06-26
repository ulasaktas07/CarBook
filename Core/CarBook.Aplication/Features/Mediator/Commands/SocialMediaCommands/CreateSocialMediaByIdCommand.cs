
namespace CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommands
{
	public record CreateSocialMediaByIdCommand(int Id)
	{
		public int Id { get; } = Id;
	}
}
