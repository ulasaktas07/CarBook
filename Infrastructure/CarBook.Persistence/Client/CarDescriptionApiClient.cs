using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.CarDescriptionDtos;
using Newtonsoft.Json;

namespace CarBook.Persistence.Client
{
	public class CarDescriptionApiClient(IHttpClientFactory httpClientFactory) : ICarDescriptionApiClient
	{
		public async Task<CarDescriptionByCarIdDto> CarDescriptionByCarIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/CarDescriptions/{id}");
			if (!response.IsSuccessStatusCode)
				return new CarDescriptionByCarIdDto()!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<CarDescriptionByCarIdDto>>(jsonData);
			return apiResponse?.Data ?? new CarDescriptionByCarIdDto()!;
		}
	}
}
