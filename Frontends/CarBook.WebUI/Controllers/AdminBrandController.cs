using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.BrandDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class AdminBrandController(IBrandApiClient brandApiClient, IBrandService brandService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var brands = await brandApiClient.GetBrandsAsync();
			return View(brands);
		}

		[HttpGet]
		public IActionResult CreateBrand()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateBrand(CreateBrandRequest createBrandRequest)
		{
			var result = await brandService.CreateBrandAsync(createBrandRequest);
			if (result)
				return RedirectToAction("Index");
			return View();

		}
		public async Task<IActionResult> RemoveBrand(int id)
		{
			var result = await brandApiClient.SendDeleteBrandAsync(id);
			if (result)
				return RedirectToAction("Index");

			return View();
		}

		[HttpGet]
		public async Task<IActionResult> UpdateBrand(int id)
		{
			var brand = await brandApiClient.GetBrandByIdAsync(id);
			if (brand == null)
				return NotFound();

			return View(brand);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateBrand(UpdateBrandRequest updateBrandRequest)
		{
			var result = await brandService.UpdateBrandAsync(updateBrandRequest);
			if (result)
				return RedirectToAction("Index");
			return View(updateBrandRequest);
		}
	}
}