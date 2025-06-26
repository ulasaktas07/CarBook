using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
	public class _GetLast3BlogsWithWriterListComponentPartial(IBlogApiClient blogApiClient):ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var last3Blogs =await blogApiClient.GetLast3BlogsWithWriterAsync();
			return View(last3Blogs);
		}
	}
}
