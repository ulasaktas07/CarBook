using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.PricingDtos;
using CarBook.Persistence.Client;
using CarBook.Persistence.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class PricingController(IPricingApiClient pricingApiClient,IPricingService pricingService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var pricings = await pricingApiClient.GetPricingsAsync();
			return View(pricings);
		}
		[HttpGet]
		public IActionResult CreatePricing()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreatePricing(CreatePricingRequest createPricingRequest)
		{
			if (!ModelState.IsValid)
			{
				return View(createPricingRequest);
			}
			var result = await pricingService.CreatePricingAsync(createPricingRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
		[HttpGet]
		public async Task<IActionResult> UpdatePricing(int id)
		{
			var Pricing = await pricingApiClient.GetPricingForUpdateAsync(id);
			if (Pricing == null)
			{
				return NotFound();
			}
			return View(Pricing);
		}
		[HttpPost]
		public async Task<IActionResult> UpdatePricing(UpdatePricingRequest updatePricingRequest)
		{
			var result = await pricingService.UpdatePricingAsync(updatePricingRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}

		public async Task<IActionResult> RemovePricing(int id)
		{
			var result = await pricingApiClient.DeletePricingAsync(id);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}

	}
}
