using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Threading.Tasks;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class StatisticsController(IStatisticsApiClient statisticsApiClient) : Controller
	{
		public async Task<IActionResult> Index()
		{
			#region İstatistik 1
			var carCount = await statisticsApiClient.GetCarCountAsync();
			ViewBag.CarCount = carCount.carCount;
			#endregion

			#region İstatistik 2
			var locationCount = await statisticsApiClient.GetLocationCountAsync();
			ViewBag.LocationCount = locationCount.locationCount;
			#endregion

			#region İstatistik 3
			var writerCount = await statisticsApiClient.GetWriterCountAsync();
			ViewBag.WriterCount = writerCount.writerCount;
			#endregion

			#region İstatistik 4
			var blogCount = await statisticsApiClient.GetBlogCountAsync();
			ViewBag.BlogCount = blogCount.blogCount;
			#endregion

			#region İstatistik 5
			var brandCount = await statisticsApiClient.GetBrandCountAsync();
			ViewBag.BrandCount = brandCount.brandCount;
			#endregion

			#region İstatistik 6
			var avrgRentPriceForDaily = await statisticsApiClient.GetAvrgRentPriceForDailyAsync();
			ViewBag.AvrgRentPriceForDaily = avrgRentPriceForDaily.avgPriceForDaily.ToString("N2", new CultureInfo("tr-TR"));
			#endregion

			#region İstatistik 7
			var avrgRentPriceForWeekly = await statisticsApiClient.GetAvrgRentPriceForWeeklyAsync();
			ViewBag.AvrgRentPriceForWeekly = avrgRentPriceForWeekly.avgPriceForWeekly.ToString("N2", new CultureInfo("tr-TR"));
			#endregion

			#region İstatistik 8
			var avrgRentPriceForMonthly = await statisticsApiClient.GetAvrgRentPriceForMonthlyAsync();
			ViewBag.AvrgRentPriceForMonthly = avrgRentPriceForMonthly.avgPriceForMonthly.ToString("N2", new CultureInfo("tr-TR"));
			#endregion

			#region İstatistik 9
			var carCountByTransmissionIsAuto = await statisticsApiClient.GetCarCountByTransmissionIsAutoAsync();
			ViewBag.CarCountByTransmissionIsAuto = carCountByTransmissionIsAuto.carCountByTransmissionIsAuto;
			#endregion

			#region İstatistik 10
			var brandNameByMaxCar = await statisticsApiClient.GetBrandNameByMaxCarAsync();
			ViewBag.BrandNameByMaxCar = brandNameByMaxCar.brandNameByMaxCar;
			#endregion

			#region İstatistik 11
			var blogTitleByMaxBlogComment = await statisticsApiClient.GetBlogTitleByMaxBlogCommentAsync();
			ViewBag.BlogTitleByMaxBlogComment = blogTitleByMaxBlogComment.blogTitleByMaxBlogComment;
			#endregion

			#region İstatistik 12
			var carCountByKmSmallerThan1000 = await statisticsApiClient.GetCarCountByKmSmallerThan1000Async();
			ViewBag.CarCountByKmSmallerThan1000 = carCountByKmSmallerThan1000.getCarCountByKmSmallerThan1000;
			#endregion

			#region İstatistik 13
			var carCountByFuelGasolineOrDiesel = await statisticsApiClient.GetCarCountByFuelGasolineOrDieselAsync();
			ViewBag.CarCountByFuelGasolineOrDiesel = carCountByFuelGasolineOrDiesel.carCountByFuelGasolineOrDiesel;
			#endregion

			#region İstatistik 14
			var carCountByFuelElectric = await statisticsApiClient.GetCarCountByFuelElectricAsync();
			ViewBag.CarCountByFuelElectric = carCountByFuelElectric.carCountByFuelElectric;
			#endregion

			#region İstatistik 15
			var carBrandAndModelByRentPriceDailyMax = await statisticsApiClient.GetCarBrandAndModelByRentPriceDailyMaxAsync();
			ViewBag.CarBrandAndModelByRentPriceDailyMax = carBrandAndModelByRentPriceDailyMax.getCarBrandAndModelByRentPriceDailyMax;
			#endregion

			#region İstatistik 16
			var carBrandAndModelByRentPriceDailyMin = await statisticsApiClient.GetCarBrandAndModelByRentPriceDailyMinAsync();
			ViewBag.CarBrandAndModelByRentPriceDailyMin = carBrandAndModelByRentPriceDailyMin.getCarBrandAndModelByRentPriceDailyMin;
			#endregion


			return View();
		}
	}
}
