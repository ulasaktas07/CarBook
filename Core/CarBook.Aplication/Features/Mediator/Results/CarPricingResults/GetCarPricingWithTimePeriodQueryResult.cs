namespace CarBook.Aplication.Features.Mediator.Results.CarPricingResults;

public class GetCarPricingWithTimePeriodQueryResult
{
	public string Model { get; set; }=default!;
	public decimal DailyPrice { get; set; }
	public decimal WeeklyPrice { get; set; }
	public decimal MonthlyPrice { get; set; }
}
