using CarBook.Aplication.Interfaces.ApiConsume;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class RentACarListController(IRentACarApiClient rentACarApiClient) : Controller
	{
		public async Task<IActionResult> Index(int id)
		{

			var locationID = TempData["locationID"];

			id=Convert.ToInt32(locationID);
			
			ViewBag.LocationID = locationID;

			var result = await rentACarApiClient.GetAvailableRentACarsAsync(id);

			return View(result);
		}
	}
}
