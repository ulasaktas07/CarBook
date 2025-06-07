namespace CarBook.Aplication.Features.CQRS.Results.AboutResults
{
	public record GetAboutByIdQueryResult(int Id, string Title, string Description, string? ImageUrl);

}
