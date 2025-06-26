
using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.CarDtos;

namespace CarBook.Persistence.Services
{
	public class CarApiClient(IHttpClientFactory httpClientFactory) : ICarApiClient
	{
		public async Task<List<CarDto>> GetCarsAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Cars");
			if (!response.IsSuccessStatusCode)
				return new List<CarDto>();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<CarDto>>(jsonData);
			return apiResponse?.Data ?? new List<CarDto>();
		}

		public async Task<List<Last5CarsWithBrandsDto>> GetLast5CarsWithBrandsAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Cars/GetLast5CarsWithBrands");
			if (!response.IsSuccessStatusCode)
				return new List<Last5CarsWithBrandsDto>();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<Last5CarsWithBrandsDto>>(jsonData);
			return apiResponse?.Data ?? new List<Last5CarsWithBrandsDto>();
		}
	}
}
