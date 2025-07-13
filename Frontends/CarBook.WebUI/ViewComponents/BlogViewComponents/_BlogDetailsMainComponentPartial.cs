using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;

public class _BlogDetailsMainComponentPartial(IBlogApiClient blogApiClient,ICommentApiClient commentApiClient) : ViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(int id)
	{
		var blog = await blogApiClient.GetBlogByIdAsync(id);

		if (blog == null || blog.id == 0)
		{
			return View("Error"); // ya da boş view
		}
		var commentCountByBlogId = await commentApiClient.GetCommentCountByBlogIdAsync(id);
		ViewBag.CommentCount = commentCountByBlogId.commentCount; // Yorum sayısını ViewBag'e ekle
		return View(blog); // Default view'e blog gönder
	}
}
