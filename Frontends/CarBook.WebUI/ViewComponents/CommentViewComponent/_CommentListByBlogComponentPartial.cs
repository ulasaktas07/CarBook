using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.ViewComponents.CommentViewComponent
{
	public class _CommentListByBlogComponentPartial(ICommentApiClient commentApiClient):ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			var comments = await commentApiClient.GetCommentListByBlogIdAsync(id);
			return View(comments);
		}
	}
}
