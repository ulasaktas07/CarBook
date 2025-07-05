using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.FeatureDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class AdminFeatureController(IFeatureApiClient featureApiClient, IFeatureService featureService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var features = await featureApiClient.GetFeaturesAsync();
			return View(features);
		}
		[HttpGet]
		public IActionResult CreateFeature()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateFeature(CreateFeatureRequest createFeatureRequest)
		{
			var result = await featureService.CreateFeatureAsync(createFeatureRequest);
			if (result)
				return RedirectToAction("Index");

			return View();

		}
		public async Task<IActionResult> RemoveFeature(int id)
		{
			var result = await featureApiClient.SendDeleteFeatureAsync(id);
			if (result)
				return RedirectToAction("Index");

			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateFeature(int id)
		{
			var features = await featureApiClient.GetFeatureByIdAsync(id);
			if (features == null)
				return NotFound();

			return View(features);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateFeature(UpdateFeatureRequest resultFeatureDto)
		{
			var result = await featureService.UpdateFeatureAsync(resultFeatureDto);
			if (result)
				return RedirectToAction("Index");
			return View(resultFeatureDto);
		}
	}
}

