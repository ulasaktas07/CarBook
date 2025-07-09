using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto.RentACarDtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.Controllers
{
	public class RentACarListController(IRentACarApiClient rentACarApiClient) : Controller
	{
		public async Task<IActionResult> Index(int id)
		{

			var locationID = TempData["locationID"];
			var locationID2 = TempData["locationID2"];

			id=Convert.ToInt32(locationID);
			
			ViewBag.LocationID = locationID;
			ViewBag.LocationID2 = locationID2;

			var result = await rentACarApiClient.GetAvailableRentACarsAsync(id);

			return View(result);
		}
	}
}
