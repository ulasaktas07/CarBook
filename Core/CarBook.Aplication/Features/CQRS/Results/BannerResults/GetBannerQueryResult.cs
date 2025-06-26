namespace CarBook.Aplication.Features.CQRS.Results.BannerResults;
public record GetBannerQueryResult(int Id,string Title,string? Description,string? VideoDescription,string? VideoUrl);

