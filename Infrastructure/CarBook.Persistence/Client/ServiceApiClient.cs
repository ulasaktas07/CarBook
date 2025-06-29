using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.ServiceDtos;

namespace CarBook.Persistence.Client
{
	public class ServiceApiClient(IHttpClientFactory httpClientFactory) : IServiceApiClient
	{
		public async Task<List<ServiceDto>> GetServicesAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Services");
			if (!response.IsSuccessStatusCode)
				return new List<ServiceDto>();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ServiceDto>>(jsonData);
			return apiResponse?.Data ?? new List<ServiceDto>();
		}
	}
}
