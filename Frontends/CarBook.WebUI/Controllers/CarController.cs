using CarBook.Dto;
using CarBook.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
	public class CarController(IHttpClientFactory httpClientFactory) : Controller
	{
		public async Task<IActionResult> Index()
		{
			ViewData["a"] = "ARABALAR";

			var client = httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7274/api/Cars/GetCarsWithBrands");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var result = JsonConvert.DeserializeObject<ApiResponse<CarDto>>(jsonData);
				return View(result?.Data ?? new List<CarDto>());
			}
			return View();
		}
	}
}
