using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Services;
using CarBook.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class ServiceController(IServiceApiClient serviceApiClient, IServiceService serviceService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var Services = await serviceApiClient.GetServicesAsync();
			return View(Services);
		}
		[HttpGet]
		public IActionResult CreateService()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateService(CreateServiceRequest createServiceRequest)
		{
			if (!ModelState.IsValid)
			{
				return View(createServiceRequest);
			}
			var result = await serviceService.CreateServiceAsync(createServiceRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
		[HttpGet]
		public async Task<IActionResult> UpdateService(int id)
		{
			var Service = await serviceApiClient.GetServiceForUpdateAsync(id);
			if (Service == null)
			{
				return NotFound();
			}
			return View(Service);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateService(UpdateServiceRequest updateServiceRequest)
		{
			var result = await serviceService.UpdateServiceAsync(updateServiceRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}

		public async Task<IActionResult> RemoveService(int id)
		{
			var result = await serviceApiClient.DeleteServiceAsync(id);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
	}
}
