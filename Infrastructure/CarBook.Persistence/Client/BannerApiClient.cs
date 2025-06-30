using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.BannerDtos;
using CarBook.Dto.FeatureDtos;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class BannerApiClient(IHttpClientFactory httpClientFactory) : IBannerApiClient
	{
		public async Task<bool> DeleteBannerAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/Banners/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return true;
		}

		public async Task<UpdateBannerRequest> GetBannerForUpdateAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Banners/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateBannerRequest();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateBannerRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdateBannerRequest();
		}

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

		public async Task<CreateBannerResult> SendCreateBannerAsync(CreateBannerRequest request)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(request);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Banners", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateBannerResult>(jsonData);
			return apiResponse!;
		}

		public async Task<UpdateBannerRequest> SendUpdateBannerAsync(UpdateBannerRequest request)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(request);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PutAsync("https://localhost:7274/api/Banners", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<UpdateBannerRequest>(jsonData);
			return apiResponse!;
		}
	}
}
