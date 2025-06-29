
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Domain.Entities;
using CarBook.Dto;
using CarBook.Dto.BrandDtos;
using CarBook.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace CarBook.Persistence.Services
{
	public class BrandApiClient(IHttpClientFactory httpClientFactory) : IBrandApiClient
	{
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
	}
}
