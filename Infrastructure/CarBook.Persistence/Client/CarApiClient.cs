using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.CarDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class CarApiClient(IHttpClientFactory httpClientFactory) : ICarApiClient
	{
		public async Task<bool> SendCreateCarAsync(CreateCarRequest request)
		{
			var client = httpClientFactory.CreateClient();

			var json = JsonConvert.SerializeObject(request);
			var content = new StringContent(json, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Cars/", content);
			if (!response.IsSuccessStatusCode)
				return false;

			return response.IsSuccessStatusCode;
		}

		public async Task<List<CarDto>> GetCarsAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Cars");
			if (!response.IsSuccessStatusCode)
				return new List<CarDto>();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<CarDto>>(jsonData);
			return apiResponse?.Data ?? new List<CarDto>();
		}

		public async Task<List<CarDto>> GetCarsWithBrandAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Cars/GetCarsWithBrands");
			if (!response.IsSuccessStatusCode)
				return new List<CarDto>();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<CarDto>>(jsonData);
			return apiResponse?.Data ?? new List<CarDto>();
		}

		public async Task<List<Last5CarsWithBrandsDto>> GetLast5CarsWithBrandsAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Cars/GetLast5CarsWithBrands");
			if (!response.IsSuccessStatusCode)
				return new List<Last5CarsWithBrandsDto>();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Last5CarsWithBrandsDto>>(jsonData);
			return apiResponse?.Data ?? new List<Last5CarsWithBrandsDto>();
		}

		public async Task<bool> SendDeleteCarAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/Cars/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return response.IsSuccessStatusCode;
		}

		public async Task<UpdateCarRequest> GetByIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Cars/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateCarRequest();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateCarRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdateCarRequest();
		}

		public async Task<bool> SendUpdateCarAsync(UpdateCarRequest result)
		{
			var client = httpClientFactory.CreateClient();
			var json = JsonConvert.SerializeObject(result);
			var content = new StringContent(json, Encoding.UTF8, "application/json");
			var response = await client.PutAsync("https://localhost:7274/api/Cars/", content);
			if (!response.IsSuccessStatusCode)
				return false;
			return response.IsSuccessStatusCode;
		}

		public async Task<CarDto> GetCarsByBrandAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Cars/{id}");
			if (!response.IsSuccessStatusCode)
				return new CarDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<CarDto>>(jsonData);
			return apiResponse?.Data ?? new CarDto();
		}
	}
}
