using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.LocationDtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class LocationApiClient(IHttpClientFactory httpClientFactory):ILocationApiClient
	{
		public async Task<bool> DeleteLocationAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/Locations/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return true;
		}

		public async Task<UpdateLocationRequest> GetLocationForUpdateAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Locations/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateLocationRequest()!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateLocationRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdateLocationRequest()!;
		}

		public async Task<List<LocationDto>> GetLocationsAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Locations");

			if (!response.IsSuccessStatusCode)
				return new List<LocationDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<LocationDto>>(jsonData);
			List<SelectListItem> selectList = new List<SelectListItem>();

			return apiResponse?.Data ?? new List<LocationDto>();
		}

		public async Task<CreateLocationResult> SendCreateLocationAsync(CreateLocationRequest createLocationRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createLocationRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Locations", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateLocationResult>(jsonData);
			return apiResponse!;
		}

		public async Task<UpdateLocationRequest> SendUpdateLocationAsync(UpdateLocationRequest updateLocationRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(updateLocationRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PutAsync($"https://localhost:7274/api/Locations/", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<UpdateLocationRequest>(jsonData);
			return apiResponse!;
		}
	}
}
