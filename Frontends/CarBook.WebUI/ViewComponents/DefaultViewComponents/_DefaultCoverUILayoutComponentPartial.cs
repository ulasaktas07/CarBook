using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.DefaultViewComponents
{
	public class _DefaultCoverUILayoutComponentPartial(IBannerApiClient bannerApiClient): ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var banners = await bannerApiClient.GetBannersAsync();

			return View(banners);
		}
	}
}
