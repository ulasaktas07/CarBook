using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Services;
using CarBook.Dto.BannerDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class BannerController(IBannerApiClient bannerApiClient, IBannerService bannerService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var banners = await bannerApiClient.GetBannersAsync();
			return View(banners);
		}
		[HttpGet]
		public IActionResult CreateBanner()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateBanner(CreateBannerRequest request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}
			var result = await bannerService.SendCreateBannerAsync(request);

			return RedirectToAction(nameof(Index) ,new { area = "Admin" });

		}
		public async Task<IActionResult> RemoveBanner(int id)
		{
			var result = await bannerApiClient.DeleteBannerAsync(id);
			if (result)
			{
				return RedirectToAction(nameof(Index), new { area = "Admin" });
			}
			return NotFound();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateBanner(int id)
		{
			var banner = await bannerApiClient.GetBannerForUpdateAsync(id);
			if (banner == null)
			{
				return NotFound();
			}
			return View(banner);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateBanner(UpdateBannerRequest request)
		{
	
			var result = await bannerService.UpdateBannerAsync(request);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
	}
}