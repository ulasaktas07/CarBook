using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CarDetailViewComponents
{
	public class _CarDetailCommentsByCarIdCommentPartial(IReviewApiClient reviewApiClient) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			ViewBag.carid = id;
			var reviews = await reviewApiClient.GetReviewByCarIdAsync(id);
			return View(reviews);
		}
	}
}
