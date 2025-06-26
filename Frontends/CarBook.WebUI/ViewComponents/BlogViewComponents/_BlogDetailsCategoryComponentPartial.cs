using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
	public class _BlogDetailsCategoryComponentPartial(ICategoryApiClient categoryApiClient) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var categories =await categoryApiClient.GetCategoryAsync();
			return View(categories);
		}
	}
}