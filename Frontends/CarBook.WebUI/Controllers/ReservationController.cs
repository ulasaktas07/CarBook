using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.ReservationDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace CarBook.WebUI.Controllers
{
	public class ReservationController(ILocationApiClient locationApiClient, IReservationService reservationService) : Controller
	{
		[HttpGet]
		public async Task<IActionResult> Index(int id)
		{
			ViewData["a"] = "ARAÇ KİRALAMA";
			ViewBag.b = "Araç Rezervasyon Form";
			ViewBag.carId = id;
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
		public async Task<IActionResult> Index(CreateReservationRequest request)
		{
			var result = await reservationService.CreateReservationAsync(request);

			return RedirectToAction(nameof(Index),"Default");

		}

	}
}
