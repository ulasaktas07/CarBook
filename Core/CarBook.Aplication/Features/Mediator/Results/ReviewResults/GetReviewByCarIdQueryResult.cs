namespace CarBook.Aplication.Features.Mediator.Results.ReviewResults;

public record GetReviewByCarIdQueryResult
	(int Id, string CustomerName, string? CustomerImage, string Comment, int RaytingValue, int CarID, DateTime Created);
