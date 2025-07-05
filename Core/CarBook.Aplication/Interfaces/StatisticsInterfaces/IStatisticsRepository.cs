namespace CarBook.Aplication.Interfaces.StatisticsInterfaces
{
	public interface IStatisticsRepository
	{
		Task<int> GetCarCountAsync();
		Task<int> GetLocationCountAsync();
		Task<int> GetWriterCountAsync();
		Task<int> GetBlogCountAsync();
		Task<int> GetBrandCountAsync();
		Task<decimal> GetAvrgRentPriceForDailyAsync();
		Task<decimal> GetAvrgRentPriceForWeeklyAsync();
		Task<decimal> GetAvrgRentPriceForMonthlyAsync();
		Task<int> GetCarCountByTransmissionIsAutoAsync();
		Task<string?> GetBrandNameByMaxCarAsync();
		Task<string?> GetBlogTitleByMaxBlogCommentAsync();
		Task<int> GetCarCountByKmSmallerThan1000Async();
		Task<int> GetCarCountByFuelGasolineOrDieselAsync();
		Task<int> GetCarCountByFuelElectricAsync();
		Task<string?> GetCarBrandAndModelByRentPriceDailyMaxAsync();
		Task<string?> GetCarBrandAndModelByRentPriceDailyMinAsync();
	}
}
