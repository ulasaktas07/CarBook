using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
	public class ServiceController(IServiceApiClient serviceApiClient) : Controller
	{
		public async Task<IActionResult> IndexAsync()
		{
			ViewData["a"]= "SERVİSLER";
			var services = await serviceApiClient.GetServicesAsync();
			return View(services);
		}
	}
}

