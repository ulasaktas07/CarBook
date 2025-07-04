using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.FooterAddressDtos;

using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class FooterAddressController(IFooterAddressApiClient footerAddressApiClient,IFooterAddressService footerAddressService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var FooterAddresss = await footerAddressApiClient.GetFooterAddressesAsync();
			return View(FooterAddresss);
		}
		[HttpGet]
		public IActionResult CreateFooterAddress()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressRequest createFooterAddressRequest)
		{
			if (!ModelState.IsValid)
			{
				return View(createFooterAddressRequest);
			}
			var result = await footerAddressService.CreateFooterAddressAsync(createFooterAddressRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
		[HttpGet]
		public async Task<IActionResult> UpdateFooterAddress(int id)
		{
			var FooterAddress = await footerAddressApiClient.GetFooterAddressForUpdateAsync(id);
			if (FooterAddress == null)
			{
				return NotFound();
			}
			return View(FooterAddress);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressRequest updateFooterAddressRequest)
		{
			var result = await footerAddressService.UpdateFooterAddressAsync(updateFooterAddressRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}

		public async Task<IActionResult> RemoveFooterAddress(int id)
		{
			var result = await footerAddressApiClient.DeleteFooterAddressAsync(id);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
	}
}
