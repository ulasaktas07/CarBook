using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.CarPricingDtos;

namespace CarBook.Persistence.Client
{
	public class CarPricingClient(IHttpClientFactory httpClientFactory) : ICarPricingClient
	{
		public async Task<List<CarPricingWithCarDto>> GetCarPricingWithCarsAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/CarPricings/GetCarPricingWithCars");
			if (!response.IsSuccessStatusCode)
				return new List<CarPricingWithCarDto>();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<CarPricingWithCarDto>>(jsonData);
			return apiResponse?.Data ?? new List<CarPricingWithCarDto>();
		}
	}
}
