using CarBook.Dto.StatisticsDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface IStatisticsApiClient
	{
		Task<StatiscticsDto> GetCarCountAsync();
		Task<StatiscticsDto> GetLocationCountAsync();
		Task<StatiscticsDto> GetWriterCountAsync();
		Task<StatiscticsDto> GetBlogCountAsync();
		Task<StatiscticsDto> GetBrandCountAsync();
		Task<StatiscticsDto> GetAvrgRentPriceForDailyAsync();
		Task<StatiscticsDto> GetAvrgRentPriceForWeeklyAsync();
		Task<StatiscticsDto> GetAvrgRentPriceForMonthlyAsync();
		Task<StatiscticsDto> GetCarCountByTransmissionIsAutoAsync();
		Task<StatiscticsDto> GetBrandNameByMaxCarAsync();
		Task<StatiscticsDto> GetBlogTitleByMaxBlogCommentAsync();
		Task<StatiscticsDto> GetCarCountByKmSmallerThan1000Async();
		Task<StatiscticsDto> GetCarCountByFuelGasolineOrDieselAsync();
		Task<StatiscticsDto> GetCarCountByFuelElectricAsync();
		Task<StatiscticsDto> GetCarBrandAndModelByRentPriceDailyMaxAsync();
		Task<StatiscticsDto> GetCarBrandAndModelByRentPriceDailyMinAsync();



	}
}
