using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.AboutDtos;
using Newtonsoft.Json;

namespace CarBook.Persistence.Client
{
	public class AboutApiClient(IHttpClientFactory httpClientFactory) : IAboutApiClient
	{
		public async Task<List<AboutDto>> GetAboutsAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Abouts");

			if (!response.IsSuccessStatusCode)
				return new List<AboutDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<AboutDto>>(jsonData);

			return apiResponse?.Data ?? new List<AboutDto>();
		}
	}
}
