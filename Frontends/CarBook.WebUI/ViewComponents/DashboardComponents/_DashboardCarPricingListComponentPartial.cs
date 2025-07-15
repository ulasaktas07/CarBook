using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.DashboardComponents
{
	public class _DashboardCarPricingListComponentPartial(ICarPricingApiClient carPricingApiClient) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var carPricingListWithModels = await carPricingApiClient.GetCarPricingListWithModelsAsync();
			return View(carPricingListWithModels);
		}
	}
}
