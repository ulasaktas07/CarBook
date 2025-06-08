namespace CarBook.Aplication.Features.CQRS.Results.CarResults;
public record GetCarQueryResult(int Id, int BrandID, string Model, string CoverImageUrl, int Km, byte Seat, byte Lunggage, string? Fuel, string BigImageUrl, string Transmission);

