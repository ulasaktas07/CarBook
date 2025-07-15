using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CarBook.WebUI.ViewComponents.DashboardComponents
{
	public class _DashboardStatisticsComponentPartial(IStatisticsApiClient statisticsApiClient) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
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
			var brandCount = await statisticsApiClient.GetBrandCountAsync();
			ViewBag.BrandCount = brandCount.brandCount;
			#endregion

			#region İstatistik 4
			var avrgRentPriceForDaily = await statisticsApiClient.GetAvrgRentPriceForDailyAsync();
			ViewBag.AvrgRentPriceForDaily = avrgRentPriceForDaily.avgPriceForDaily.ToString("N2", new CultureInfo("tr-TR"));
			#endregion

			
			return View();
		}
	}
}
