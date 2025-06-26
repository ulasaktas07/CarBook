namespace CarBook.Aplication.Features.Mediator.Results.ServiceResults;
public record GetServiceByIdQueryResult(int Id, string Title, string? Description, string? IconUrl);
