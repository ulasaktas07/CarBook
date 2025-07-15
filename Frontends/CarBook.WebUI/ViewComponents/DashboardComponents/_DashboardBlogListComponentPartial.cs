using CarBook.Aplication.Interfaces;
using CarBook.Persistence.Client;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.DashboardComponents
{
	public class _DashboardBlogListComponentPartial(IBlogApiClient blogApiClient) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var blogs = await blogApiClient.GetAllBlogsWithWriterAsync();
			return View(blogs);
		}
	}
}
