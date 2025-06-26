namespace CarBook.Aplication.Features.Mediator.Results.BlogResults;
	public record GetLast3BlogsWithWritersQueryResult(int Id, string Title, int WriterID,string WriterName, string CoverImageUrl,
		int CategoryID,DateTime Created);
