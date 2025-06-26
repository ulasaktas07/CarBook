using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
	public class _BlogDetailsRecentBlogsComponentPartial(IBlogApiClient blogApiClient) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var categories = await blogApiClient.GetLast3BlogsWithWriterAsync();
			return View(categories);
		}
	}
}
