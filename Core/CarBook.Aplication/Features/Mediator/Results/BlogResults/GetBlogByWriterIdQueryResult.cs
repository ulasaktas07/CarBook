namespace CarBook.Aplication.Features.Mediator.Results.BlogResults;
public record GetBlogByWriterIdQueryResult(int Id, string WriterName, string WriterDescription, string? WriterImageUrl,
	 int WriterID);
