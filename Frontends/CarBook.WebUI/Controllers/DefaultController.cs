using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarBook.WebUI.Controllers
{
	public class DefaultController(ILocationApiClient locationApiClient) : Controller
	{
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var locations = await locationApiClient.GetLocationsAsync();
			List<SelectListItem> selectList = new List<SelectListItem>();
			foreach (var location in locations)
			{
				selectList.Add(new SelectListItem
				{
					Text = location.Name,
					Value = location.Id.ToString()
				});
			}
			ViewBag.Locations = selectList;

			return View();

		}

		[HttpPost]
		public IActionResult Index(string book_pick_date, string book_off_date,
			string time_pick, string time_off, string locationID )
		{
			TempData["bookpickdate"] = book_pick_date;
			TempData["bookoffdate"] = book_off_date;
			TempData["timepick"] = time_pick;
			TempData["timeoff"] = time_off;
			TempData["locationID"] = locationID;
			return RedirectToAction("Index", "RentACarList");
		}
	}
}
