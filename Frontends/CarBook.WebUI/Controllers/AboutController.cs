using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			ViewData["a"] = "Hakkımızda";
			return View();
		}
	}
}
