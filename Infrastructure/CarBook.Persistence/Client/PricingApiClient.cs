using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.PricingDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class PricingApiClient(IHttpClientFactory httpClientFactory) : IPricingApiClient
	{
		public async Task<bool> DeletePricingAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/Pricings/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return true;
		}

		public async Task<UpdatePricingRequest> GetPricingForUpdateAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Pricings/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdatePricingRequest()!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdatePricingRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdatePricingRequest()!;
		}

		public async Task<List<PricingDto>> GetPricingsAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Pricings");

			if(!response.IsSuccessStatusCode)
				return new List<PricingDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse=JsonConvert.DeserializeObject<ApiResponse<PricingDto>>(jsonData);

			return apiResponse?.Data ?? new List<PricingDto>();

		}

		public async Task<CreatePricingResult> SendCreatePricingAsync(CreatePricingRequest createPricingRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createPricingRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync($"https://localhost:7274/api/Pricings", content);
			if (!response.IsSuccessStatusCode)
				return null!;

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreatePricingResult>(jsonData);
			return apiResponse!;

		}

		public async Task<UpdatePricingRequest> SendUpdatePricingAsync(UpdatePricingRequest updatePricingRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(updatePricingRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PutAsync($"https://localhost:7274/api/Pricings", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<UpdatePricingRequest>(jsonData);
			return apiResponse!;
		}
	}
}
