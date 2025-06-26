using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
	public class _BlogDetailsWritterAboutComponentPartial(IBlogApiClient blogApiClient):ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			var writer = await blogApiClient.GetWriterByBlogIdAsync(id);
			return View(writer);
		}
	}
}
