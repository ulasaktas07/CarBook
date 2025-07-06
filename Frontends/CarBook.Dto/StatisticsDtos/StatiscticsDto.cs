namespace CarBook.Dto.StatisticsDtos
{
	public class StatiscticsDto
	{
		public int carCount { get; set; }
		public int locationCount { get; set; }
		public int writerCount { get; set; }
		public int blogCount { get; set; }
		public int brandCount { get; set; }
		public decimal avgPriceForDaily { get; set; }
		public decimal avgPriceForWeekly { get; set; }
		public decimal avgPriceForMonthly { get; set; }
		public int carCountByTransmissionIsAuto { get; set; }
		public string? brandNameByMaxCar { get; set; }
		public string? blogTitleByMaxBlogComment { get; set; }
		public int getCarCountByKmSmallerThan1000 { get; set; }
		public int carCountByFuelGasolineOrDiesel { get; set; }
		public int carCountByFuelElectric { get; set; }
		public string? getCarBrandAndModelByRentPriceDailyMax { get; set; }
		public string? getCarBrandAndModelByRentPriceDailyMin { get; set; }
		}
}
