using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
	public class _AboutUsComponentPartial(IAboutApiClient aboutApiClient):ViewComponent()
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var abouts = await aboutApiClient.GetAboutsAsync();

			return View(abouts);
		}
	}
}
