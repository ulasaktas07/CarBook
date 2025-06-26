namespace CarBook.Aplication.Features.CQRS.Commands.BannerCommands;
	public record UpdateBannerCommand(int Id, string Title, string? Description, string? VideoDescription, string? VideoUrl);