using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Interfaces.TagCloudInterfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
	public class _BlogDetailCloudTagByBlogComponentPartial(ITagCloudApiClient tagCloudApiClient) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			ViewBag.blogId = id;
			var tagClouds = await tagCloudApiClient.GetTagCloudsByBlogIdAsync(id);
			return View(tagClouds);
		}
	}
}
