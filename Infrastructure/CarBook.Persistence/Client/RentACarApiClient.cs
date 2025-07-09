using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.RentACarDtos;
using Newtonsoft.Json;

namespace CarBook.Persistence.Client
{
	public class RentACarApiClient(IHttpClientFactory httpClientFactory) : IRentACarApiClient
	{
		public async Task<List<FilterRentACarDto>> GetAvailableRentACarsAsync(int id)
		{

			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/RentACars?LocationID={id}&Available=true");
			if (!response.IsSuccessStatusCode)
				return new List<FilterRentACarDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<FilterRentACarDto>>(jsonData);
			return apiResponse?.Data ?? new List<FilterRentACarDto>();
		}
	}
}
