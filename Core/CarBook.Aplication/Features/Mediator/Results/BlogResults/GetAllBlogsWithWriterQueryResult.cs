namespace CarBook.Aplication.Features.Mediator.Results.BlogResults;
public record GetAllBlogsWithWriterQueryResult(int Id, string Title,string WriterName,string WriterDescription, string? WriterImageUrl, 
	string CategoryName,int WriterID, string CoverImageUrl, int CategoryID, DateTime Created,string Description);