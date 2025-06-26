using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Interfaces.TagCloudInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
	public class _BlogDetailsTagCloudComponentPartial(ITagCloudApiClient tagCloudApiClient) : ViewComponent
	{

		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			ViewBag.blogId = id;

			var tagClouds = await tagCloudApiClient.GetTagCloudsByBlogIdAsync(id);

			return View(tagClouds);
		}
	}
}
