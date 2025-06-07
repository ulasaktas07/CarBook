namespace CarBook.Aplication.Features.Results.AboutResults
{
	public record GetAboutByIdQueryResult(int Id, string Title, string Description, string? ImageUrl);

}
