using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.BrandDtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class BrandApiClient(IHttpClientFactory httpClientFactory) : IBrandApiClient
	{
		public async Task<UpdateBrandRequest> GetBrandByIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Brands/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateBrandRequest();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiIdResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateBrandRequest>>(jsonData);
			return apiIdResponse?.Data ?? new UpdateBrandRequest();

		}

		public async Task<List<BrandDto>> GetBrandsAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Brands");
			var jsonData = await response.Content.ReadAsStringAsync();
			if (!response.IsSuccessStatusCode)
				return new List<BrandDto>();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<BrandDto>>(jsonData);
			List<SelectListItem> selectList = new List<SelectListItem>();
		
			return apiResponse?.Data ?? new List<BrandDto>();

		}

		public async Task<bool> SendCreateBrandAsync(CreateBrandRequest createBrandRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createBrandRequest);
			var content = new StringContent(jsonContent,Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Brands", content);
			if(!response.IsSuccessStatusCode)
				return false;

			return response.IsSuccessStatusCode;


		}

		public async Task<bool> SendDeleteBrandAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/Brands/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return response.IsSuccessStatusCode;
		}

		public async Task<bool> SendUpdateBrandAsync(UpdateBrandRequest updateBrandRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(updateBrandRequest);
			var content = new StringContent(jsonContent,Encoding.UTF8, "application/json");
			var response = await client.PutAsync("https://localhost:7274/api/Brands", content);
			if (!response.IsSuccessStatusCode)
				return false;
			return response.IsSuccessStatusCode;
		}
	}
}
