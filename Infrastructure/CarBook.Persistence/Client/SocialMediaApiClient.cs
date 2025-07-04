using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.SocialMediaDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class SocialMediaApiClient(IHttpClientFactory httpClientFactory) : ISocialMediaApiClient
	{
		public async Task<bool> DeleteSocialMediaAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/SocialMedias/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return true;
		}

		public async Task<UpdateSocialMediaRequest> GetSocialMediaForUpdateAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/SocialMedias/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateSocialMediaRequest()!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateSocialMediaRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdateSocialMediaRequest()!;
		}

		public async Task<List<SocialMediaDto>> GetSocialMediasAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/SocialMedias");

			if (!response.IsSuccessStatusCode)
				return new List<SocialMediaDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<SocialMediaDto>>(jsonData);

			return apiResponse?.Data ?? new List<SocialMediaDto>();
		}

		public async Task<CreateSocialMediaResult> SendCreateSocialMediaAsync(CreateSocialMediaRequest createSocialMediaRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createSocialMediaRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/SocialMedias", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateSocialMediaResult>(jsonData);
			return apiResponse!;
		}

		public async Task<UpdateSocialMediaRequest> SendUpdateSocialMediaAsync(UpdateSocialMediaRequest updateSocialMediaRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(updateSocialMediaRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PutAsync($"https://localhost:7274/api/SocialMedias/", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<UpdateSocialMediaRequest>(jsonData);
			return apiResponse!;
		}
	}
}
