namespace CarBook.Aplication.Features.CQRS.Commands.CarCommands;
public record UpdateCarCommand(int Id, int BrandID, string Model, string CoverImageUrl, int Km, byte Seat, byte Lunggage, string? Fuel, string BigImageUrl, string Transmission);
