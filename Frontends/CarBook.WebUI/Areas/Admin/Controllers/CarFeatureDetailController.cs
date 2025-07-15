using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto.CarFeatureDtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class CarFeatureDetailController(ICarFeatureApiClient carFeatureApiClient, IFeatureApiClient featureApiClient) : Controller
	{
		[HttpGet]
		public async Task<IActionResult> Index(int id)
		{
			var carFeatures = await carFeatureApiClient.GetCarFeaturesByCarIdAsync(id);
			return View(carFeatures);
		}
		[HttpPost]
		public async Task<IActionResult> Index(List<CarFeatureByCarIdDto> carFeatureByCarIdDtos)
		{

			foreach (var item in carFeatureByCarIdDtos) 
			{
				if (item.available)
				{
					var result = await carFeatureApiClient.ChangeCarFeatureAvailableToTrueAsync(item);
				}
				else
				{
					var result = await carFeatureApiClient.ChangeCarFeatureAvailableToFalseAsync(item);
				}

			}
			return RedirectToAction("Index", "AdminCar");
		}
		[HttpGet]
		public async Task<IActionResult> CreateFeatureByCarId()
		{
			var features = await featureApiClient.GetFeaturesAsync();

			return View(features);
		}


	}
}
