namespace CarBook.Aplication.Features.CQRS.Results.AboutResults
{
	public record GetAboutQueryResult(int Id,string Title,string Description, string? ImageUrl);
}
