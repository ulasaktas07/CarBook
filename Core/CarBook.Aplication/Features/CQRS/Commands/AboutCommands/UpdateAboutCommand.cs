namespace CarBook.Aplication.Features.CQRS.Commands.AboutCommands
{
	public record UpdateAboutCommand(int Id, string Title, string Description, string? ImageUrl);
}
