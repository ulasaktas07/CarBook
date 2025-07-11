namespace CarBook.Aplication.Features.Mediator.Results.CarPricingResults;
	public record GetCarPricingWithCarQueryResult(int Id,int CarId, string Brand,string Model,decimal Price,string CoverImageUrl);
