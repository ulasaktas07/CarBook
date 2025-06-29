using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.BannerDtos;
using Newtonsoft.Json;

namespace CarBook.Persistence.Client
{
	public class BannerApiClient(IHttpClientFactory httpClientFactory) : IBannerApiClient
	{
		public async Task<List<BannerDto>> GetBannersAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Banners");

			if (!response.IsSuccessStatusCode)
				return new List<BannerDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<BannerDto>>(jsonData);

			return apiResponse?.Data ?? new List<BannerDto>();
		}
	}
}
