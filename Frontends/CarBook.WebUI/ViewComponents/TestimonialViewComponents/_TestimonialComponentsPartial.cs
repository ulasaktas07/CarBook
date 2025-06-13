using CarBook.Dto;
using CarBook.Dto.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.TestimonialViewComponents
{
	public class _TestimonialComponentsPartial(IHttpClientFactory httpClientFactory) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = httpClientFactory.CreateClient();
			var responseMessage=await client.GetAsync("https://localhost:7274/api/Testimonials");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var result = JsonConvert.DeserializeObject<ApiResponse<TestimonialDto>> (jsonData);
				return View(result?.Data ?? new List<TestimonialDto>());
			}
			return View();
		}
	}
}
