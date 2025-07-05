using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class StatisticsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
