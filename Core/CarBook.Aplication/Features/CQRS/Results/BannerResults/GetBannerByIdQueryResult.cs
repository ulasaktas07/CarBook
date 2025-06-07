namespace CarBook.Aplication.Features.CQRS.Results.BannerResults;
	public record GetBannerByIdQueryResult(int Id, string Title, string? Description, string? VideoDescription, string? VideoUrl);
