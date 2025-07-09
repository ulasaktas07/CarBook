namespace CarBook.Aplication.Features.Mediator.Results.RentACarResults;

public record GetRentACarQueryResult(int CarID, string Brand, string Model, decimal Price, string CoverImageUrl);