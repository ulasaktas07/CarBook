using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class ServiceController : Controller
	{
		public  IActionResult Index()
		{
			ViewData["a"]= "SERVİSLER";
			ViewBag.b = "HİZMETLERİMİZ";
			return View();
		}
	}
}

