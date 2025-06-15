using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.DefaultViewComponents
{
	public class _DefaultLast5CarsWithBrandsComponentPartial(ICarApiClient carApiClient): ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var last5CarsWithBrands =await carApiClient.GetLast5CarsWithBrandsAsync();
			return View(last5CarsWithBrands);
		}

	}
}
