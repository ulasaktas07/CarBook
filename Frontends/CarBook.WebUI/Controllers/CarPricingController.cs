using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.Controllers
{
	public class CarPricingController(ICarPricingApiClient carPricingApiClient) : Controller
	{
		public async Task<IActionResult> Index()
		{
			ViewData["a"] = "Paketler";
			ViewBag.b = "ARAÇ FİYAT PAKETLERİ";
			var carPricingListWithModels = await carPricingApiClient.GetCarPricingListWithModelsAsync();
			return View(carPricingListWithModels);
		}
	}
}
