using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.SocialMediaDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class SocialMediaController(ISocialMediaApiClient socialMediaApiClient, ISocialMediaService socialMediaService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var SocialMedias = await socialMediaApiClient.GetSocialMediasAsync();
			return View(SocialMedias);
		}
		[HttpGet]
		public IActionResult CreateSocialMedia()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaRequest createSocialMediaRequest)
		{
			if (!ModelState.IsValid)
			{
				return View(createSocialMediaRequest);
			}
			var result = await socialMediaService.CreateSocialMediaAsync(createSocialMediaRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
		[HttpGet]
		public async Task<IActionResult> UpdateSocialMedia(int id)
		{
			var SocialMedia = await socialMediaApiClient.GetSocialMediaForUpdateAsync(id);
			if (SocialMedia == null)
			{
				return NotFound();
			}
			return View(SocialMedia);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaRequest updateSocialMediaRequest)
		{
			var result = await socialMediaService.UpdateSocialMediaAsync(updateSocialMediaRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}

		public async Task<IActionResult> RemoveSocialMedia(int id)
		{
			var result = await socialMediaApiClient.DeleteSocialMediaAsync(id);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
	}
}
