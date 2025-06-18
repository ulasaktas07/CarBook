using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
	public class CarController(ICarPricingClient carPricingClient) : Controller
	{
		public async Task<IActionResult> Index()
		{
			ViewData["a"] = "ARABALAR";
			ViewBag.b= "ARABALARIMIZ";
			var cars = await carPricingClient.GetCarPricingWithCarsAsync();
			return View(cars);
		}
	}
}
