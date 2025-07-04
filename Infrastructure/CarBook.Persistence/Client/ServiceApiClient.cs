using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.ServiceDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class ServiceApiClient(IHttpClientFactory httpClientFactory) : IServiceApiClient
	{
		public async Task<bool> DeleteServiceAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/Services/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return true;
		}

		public async Task<UpdateServiceRequest> GetServiceForUpdateAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Services/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateServiceRequest()!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateServiceRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdateServiceRequest()!;
		}

		public async Task<List<ServiceDto>> GetServicesAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Services");

			if (!response.IsSuccessStatusCode)
				return new List<ServiceDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<ServiceDto>>(jsonData);

			return apiResponse?.Data ?? new List<ServiceDto>();
		}

		public async Task<CreateServiceResult> SendCreateServiceAsync(CreateServiceRequest createServiceRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createServiceRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Services", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateServiceResult>(jsonData);
			return apiResponse!;
		}

		public async Task<UpdateServiceRequest> SendUpdateServiceAsync(UpdateServiceRequest updateServiceRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(updateServiceRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PutAsync($"https://localhost:7274/api/Services/", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<UpdateServiceRequest>(jsonData);
			return apiResponse!;
		}
	}
}