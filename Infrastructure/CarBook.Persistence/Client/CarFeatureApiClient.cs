using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.CarFeatureDtos;
using Newtonsoft.Json;

namespace CarBook.Persistence.Client
{
	public class CarFeatureApiClient(IHttpClientFactory httpClientFactory) : ICarFeatureApiClient
	{
		public async Task<CarFeatureByCarIdDto> ChangeCarFeatureAvailableToFalseAsync(CarFeatureByCarIdDto carFeatureByCarIdDto)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/CarFeatures/ChangeCarFeatureAvailableToFalse/{carFeatureByCarIdDto.id}");
			if (!response.IsSuccessStatusCode)
				return null!;

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<CarFeatureByCarIdDto>>(jsonData);
			return apiResponse?.Data ?? null!;
		}

		public async Task<CarFeatureByCarIdDto> ChangeCarFeatureAvailableToTrueAsync(CarFeatureByCarIdDto carFeatureByCarIdDto)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/CarFeatures/ChangeCarFeatureAvailableToTrue/{carFeatureByCarIdDto.id}");
			if (!response.IsSuccessStatusCode)
				return null!;

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<CarFeatureByCarIdDto>>(jsonData);
			return apiResponse?.Data ?? null!;
		}

		public async Task<List<CarFeatureByCarIdDto>> GetCarFeaturesByCarIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/CarFeatures/GetCarFeaturesByCarId/{id}");

			if(!response.IsSuccessStatusCode)
				return new List<CarFeatureByCarIdDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<CarFeatureByCarIdDto>>(jsonData);
			return apiResponse?.Data ?? new List<CarFeatureByCarIdDto>();

		}
	}
}
