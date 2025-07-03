using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class CommentController(ICommentApiClient commentApiClient) : Controller
	{
		public async Task<IActionResult> Index(int id)
		{
			ViewBag.BlogId = id;
			var result = await commentApiClient.GetCommentListByBlogIdAsync(id); 
			return View(result);
		}
	}
}
