using CarBook.Dto.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
	public class _AboutUsComponentPartial(IHttpClientFactory httpClientFactory):ViewComponent()
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = httpClientFactory.CreateClient();

			var response = await client.GetAsync("https://localhost:7274/api/Abouts");

			if (response.IsSuccessStatusCode)
			{
				var jsonData = await response.Content.ReadAsStringAsync();

				var result = JsonConvert.DeserializeObject<AboutApiResponse>(jsonData);

				return View(result?.Data ?? new List<AboutDto>());
			}

			return View(new List<AboutDto>());
		}
	}
}
