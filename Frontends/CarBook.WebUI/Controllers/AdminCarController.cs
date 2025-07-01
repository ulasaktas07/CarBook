using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarBook.WebUI.Controllers
{
	public class AdminCarController(ICarApiClient carApiClient, IBrandApiClient brandApiClient,ICarService carService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var cars = await carApiClient.GetCarsWithBrandAsync();
			return View(cars);
		}

		[HttpGet]
		public async Task<IActionResult> CreateCar()
		{
			var brands = await brandApiClient.GetBrandsAsync();
			List<SelectListItem> selectList = new List<SelectListItem>();
			foreach (var brand in brands)
			{
				selectList.Add(new SelectListItem
				{
					Text = brand.name,
					Value = brand.id.ToString()
				});
			}
			ViewBag.Brands = selectList;

			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateCar(CreateCarRequest request)
		{
			var result = await carService.CreateCarAsync(request);
			if (result)
				return RedirectToAction("Index", "AdminCar");

			return View(request);
		}
		public async Task<IActionResult> RemoveCar(int id)
		{
			var result = await carApiClient.SendDeleteCarAsync(id);
			if (result)
			{
				return RedirectToAction("Index", "AdminCar");
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateCar(int id)
		{
			var car = await carApiClient.GetByIdAsync(id);
			if (car == null)
			{
				return NotFound();
			}
			var brands = await brandApiClient.GetBrandsAsync();
			List<SelectListItem> selectList = new List<SelectListItem>();
			foreach (var brand in brands)
			{
				selectList.Add(new SelectListItem
				{
					Text = brand.name,
					Value = brand.id.ToString()
				});
			}
			ViewBag.Brands = selectList;
			return View(car);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateCar(UpdateCarRequest resultCarDto)
		{
			if (ModelState.IsValid)
			{
				var result = await carService.UpdateCarAsync(resultCarDto);
				if (result)
				{
					return RedirectToAction("Index", "AdminCar");
				}
			}
			return View(resultCarDto);
		}
	}
}
