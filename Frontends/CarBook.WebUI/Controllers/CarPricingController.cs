using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class CarPricingController : Controller
	{
		public IActionResult Index()
		{
			ViewData["a"] = "Paketler";
			ViewBag.b = "ARAÇ FİYAT PAKETLERİ";
			return View();
		}
	}
}
