namespace CarBook.Aplication.Features.CQRS.Commands.BannerCommands;
	public record CreateBannerCommand(string Title, string? Description, string? VideoDescription, string? VideoUrl);

