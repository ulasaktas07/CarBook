namespace CarBook.Aplication.Features.Mediator.Results.BlogResults;

	public record GetBlogByIdQueryResult(int Id, string Title, int WriterID, string CoverImageUrl, int CategoryID, string Description);
