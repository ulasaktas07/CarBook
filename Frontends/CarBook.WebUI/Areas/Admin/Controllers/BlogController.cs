using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class BlogController(IBlogApiClient blogApiClient) : Controller
	{
		public  async Task<IActionResult> Index()
		{
			var blogs = await blogApiClient.GetAllBlogsWithWriterAsync();
			return View(blogs);
		}
		//delete
		public async Task<IActionResult> RemoveBlog(int id)
		{
			var result = await blogApiClient.DeleteBlogAsync(id);
			if (result)
			{
				return RedirectToAction(nameof(Index), new { area = "Admin" });
			}
			return NotFound();
		}
	}
}
