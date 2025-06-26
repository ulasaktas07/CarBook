using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.CategoryDtos;
using Newtonsoft.Json;

namespace CarBook.Persistence.Services
{
	public class CategoryApiClient(IHttpClientFactory httpClientFactory) : ICategoryApiClient
	{
		public async Task<List<CategoryDto>> GetCategoryAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Categories");

			if (!response.IsSuccessStatusCode)
				return new List<CategoryDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<CategoryDto>>(jsonData);

			return apiResponse?.Data ?? new List<CategoryDto>();
		}
	}
}
