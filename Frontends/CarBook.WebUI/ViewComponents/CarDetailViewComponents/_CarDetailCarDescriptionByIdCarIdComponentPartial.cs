using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CarDetailViewComponents
{
	public class _CarDetailCarDescriptionByIdCarIdComponentPartial(ICarDescriptionApiClient carDescriptionApiClient):ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			ViewBag.carid = id;
			var carDescription = await carDescriptionApiClient.CarDescriptionByCarIdAsync(id);
			return View(carDescription);
		}
	}
}
