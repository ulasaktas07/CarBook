using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
	public class CarController(ICarApiClient carApiClient) : Controller
	{
		public async Task<IActionResult> Index()
		{
			ViewData["a"] = "ARABALAR";
			var cars = await carApiClient.GetCarsAsync();
			return View(cars);
		}
	}
}
