using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

public class _BlogDetailsMainComponentPartial(IBlogApiClient blogApiClient) : ViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(int id)
	{
		var blog = await blogApiClient.GetBlogByIdAsync(id);

		if (blog == null || blog.id == 0)
		{
			return View("Error"); // ya da boş view
		}

		return View(blog); // Default view'e blog gönder
	}
}
