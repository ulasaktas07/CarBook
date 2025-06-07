namespace CarBook.Aplication.Features.Commands.AboutCommands
{
	public record UpdateAboutCommand(int Id, string Title, string Description, string? ImageUrl);
}
