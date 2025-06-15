namespace CarBook.Aplication.Features.Mediator.Results.WriterResults;
public record GetWriterByIdQueryResult(int Id,string Name,string? ImageUrl, string Description);
