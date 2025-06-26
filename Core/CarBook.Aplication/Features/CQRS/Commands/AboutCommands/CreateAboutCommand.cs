namespace CarBook.Aplication.Features.CQRS.Commands.AboutCommands
{
	public record CreateAboutCommand(string Title, string Description, string? ImageUrl);

}
