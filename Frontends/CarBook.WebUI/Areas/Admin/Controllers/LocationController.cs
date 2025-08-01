﻿using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.LocationDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Authorize(Roles = "Admin")]
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class LocationController(ILocationApiClient locationApiClient, ILocationService locationService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			
			var locations = await locationApiClient.GetLocationsAsync();
			return View(locations);
		}
		[HttpGet]
		public IActionResult CreateLocation()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateLocation(CreateLocationRequest createLocationRequest)
		{
			if (!ModelState.IsValid)
			{
				return View(createLocationRequest);
			}
			var result = await locationService.CreateLocationAsync(createLocationRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
		[HttpGet]
		public async Task<IActionResult> UpdateLocation(int id)
		{
			var Location = await locationApiClient.GetLocationForUpdateAsync(id);
			if (Location == null)
			{
				return NotFound();
			}
			return View(Location);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateLocation(UpdateLocationRequest updateLocationRequest)
		{
			var result = await locationService.UpdateLocationAsync(updateLocationRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}

		public async Task<IActionResult> RemoveLocation(int id)
		{
			var result = await locationApiClient.DeleteLocationAsync(id);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
	}
}