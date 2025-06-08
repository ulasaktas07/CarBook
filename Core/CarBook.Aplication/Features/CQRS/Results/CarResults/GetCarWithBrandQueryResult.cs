namespace CarBook.Aplication.Features.CQRS.Results.CarResults;
	public record GetCarWithBrandQueryResult(int Id, int BrandID,string BrandName, string Model, string CoverImageUrl, int Km, byte Seat, byte Lunggage,
		string? Fuel, string BigImageUrl, string Transmission);

