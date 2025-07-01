using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.AboutDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class AboutController(IAboutApiClient aboutApiClient, IAboutService aboutService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var abouts = await aboutApiClient.GetAboutsAsync();
			return View(abouts);
		}
		[HttpGet]
		public IActionResult CreateAbout()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateAbout(CreateAboutRequest createAboutRequest)
		{
			if (!ModelState.IsValid)
			{
				return View(createAboutRequest);
			}
			var result = await aboutService.CreateAboutAsync(createAboutRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
		[HttpGet]
		public async Task<IActionResult> UpdateAbout(int id)
		{
			var about = await aboutApiClient.GetAboutForUpdateAsync(id);
			if (about == null)
			{
				return NotFound();
			}
			return View(about);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateAbout(UpdateAboutRequest updateAboutRequest)
		{
			var result = await aboutService.UpdateAboutAsync(updateAboutRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}

		public async Task<IActionResult> RemoveAbout(int id)
		{
			var result = await aboutApiClient.DeleteAboutAsync(id);
	
			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
	}
}
