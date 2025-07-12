using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.ViewComponents.DefaultViewComponents
{
	public class _DefaultStatisticsComponentPartial(IStatisticsApiClient statisticsApiClient) :ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var statistics = await statisticsApiClient.GetCarCountAsync();
			ViewBag.CarCount = statistics.carCount;
			var statistics2 = await statisticsApiClient.GetLocationCountAsync();
			ViewBag.LocationCount = statistics2.locationCount;
			var statistics3 = await statisticsApiClient.GetBrandCountAsync();
			ViewBag.BrandCount = statistics3.brandCount;
			var statistics4 = await statisticsApiClient.GetCarCountByFuelElectricAsync();
			ViewBag.CarCountByFuelElectric = statistics4.carCountByFuelElectric;
			return View();
		}
	}
}
