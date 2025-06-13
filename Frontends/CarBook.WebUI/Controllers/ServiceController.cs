using CarBook.Dto;
using CarBook.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
	public class ServiceController(IHttpClientFactory httpClientFactory) : Controller
	{
		public async Task<IActionResult> IndexAsync()
		{
			ViewData["a"]= "SERVİSLER";

			var client = httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7274/api/Services");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var result = JsonConvert.DeserializeObject<ApiResponse<ServiceDto>>(jsonData);
				return View(result?.Data ?? new List<ServiceDto>());
			}
			return View();
		}
	}
}

