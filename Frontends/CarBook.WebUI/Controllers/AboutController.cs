using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			ViewData["a"] = "Hakkımızda";
			ViewBag.b = "VİZYONUMUZ & MİSYONUMUZ";
			return View();
		}
	}
}
