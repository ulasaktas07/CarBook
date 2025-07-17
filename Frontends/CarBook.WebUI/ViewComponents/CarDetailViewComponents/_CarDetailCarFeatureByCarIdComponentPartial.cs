using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CarDetailViewComponents
{
	public class _CarDetailCarFeatureByCarIdComponentPartial(ICarFeatureApiClient carFeatureApiClient): ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			ViewBag.carid= id;
			var carFeatures = await carFeatureApiClient.GetCarFeaturesByCarIdAsync(id);

			return View(carFeatures);
		}
	}
}
