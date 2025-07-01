using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.CategoryDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class CategoryApiClient(IHttpClientFactory httpClientFactory) : ICategoryApiClient
	{
		public async Task<UpdateCategoryRequest> GetCategoryForUpdateAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Categories/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateCategoryRequest()!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateCategoryRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdateCategoryRequest()!;
		}

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

		public async Task<CreateCategoryResult> SendCreateCategoryAsync(CreateCategoryRequest request)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(request);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Categories", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateCategoryResult>(jsonData);
			return apiResponse!;
		}

		public async Task<UpdateCategoryRequest> SendUpdateCategoryAsync(UpdateCategoryRequest request)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(request);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PutAsync("https://localhost:7274/api/Categories", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<UpdateCategoryRequest>(jsonData);
			return apiResponse!;
		}

		public async Task<bool> DeleteCategoryAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/Categories/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return true;
		}
	}
}
