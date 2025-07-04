using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.AboutDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class AboutApiClient(IHttpClientFactory httpClientFactory) : IAboutApiClient
	{
		public async Task<bool> DeleteAboutAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/Abouts/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return true;
		}

		public async Task<UpdateAboutRequest> GetAboutForUpdateAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Abouts/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateAboutRequest()!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateAboutRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdateAboutRequest()!;
		}

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

		public async Task<CreateAboutResult> SendCreateAboutAsync(CreateAboutRequest createAboutRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createAboutRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Abouts", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateAboutResult>(jsonData);
			return apiResponse!;
		}

		public async Task<UpdateAboutRequest> SendUpdateAboutAsync(UpdateAboutRequest updateAboutRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(updateAboutRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PutAsync($"https://localhost:7274/api/Abouts/", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<UpdateAboutRequest>(jsonData);
			return apiResponse!;
		}
	}
}
