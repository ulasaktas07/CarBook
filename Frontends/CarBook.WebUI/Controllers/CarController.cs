using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class CarController(ICarPricingApiClient carPricingClient) : Controller
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
