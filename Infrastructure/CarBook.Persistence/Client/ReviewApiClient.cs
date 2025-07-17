using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.CarFeatureDtos;
using CarBook.Dto.ReviewDtos;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBook.Persistence.Client
{
	public class ReviewApiClient(IHttpClientFactory httpClientFactory) : IReviewApiClient
	{
		public async Task<List<ReviewByCarIdDto>> GetReviewByCarIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Reviews/GetReviewsByCarId/{id}");

			if (!response.IsSuccessStatusCode)
				return new List<ReviewByCarIdDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<ReviewByCarIdDto>>(jsonData);
			return apiResponse?.Data ?? new List<ReviewByCarIdDto>();
		}
	}
}
