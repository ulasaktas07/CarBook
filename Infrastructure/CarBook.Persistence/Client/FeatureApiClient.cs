﻿using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.FeatureDtos;
using Newtonsoft.Json;
using System.Text;
namespace CarBook.Persistence.Client
{
	public class FeatureApiClient(IHttpClientFactory httpClientFactory) : IFeatureApiClient
	{
		public async Task<UpdateFeatureRequest> GetFeatureByIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Features/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateFeatureRequest();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateFeatureRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdateFeatureRequest();
		}

		public async Task<List<FeatureDto>> GetFeaturesAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Features");

			if (!response.IsSuccessStatusCode)
				return new List<FeatureDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse =JsonConvert.DeserializeObject<ApiResponse<FeatureDto>>(jsonData);

			return apiResponse?.Data ?? new List<FeatureDto>();

		}

		public async Task<bool> SendCreateFeatureAsync(CreateFeatureRequest createFeatureRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createFeatureRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Features", content);
			if (!response.IsSuccessStatusCode)
				return false;
			return response.IsSuccessStatusCode; 
		}

		public async Task<bool> SendDeleteFeatureAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/Features/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return response.IsSuccessStatusCode;
		}

		public async Task<bool> SendUpdateFeatureAsync(UpdateFeatureRequest resultFeatureDto)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(resultFeatureDto);
			var content = new StringContent(jsonContent,Encoding.UTF8, "application/json");
			var response = await client.PutAsync($"https://localhost:7274/api/Features/", content);
			if (!response.IsSuccessStatusCode)
				return false;
			return response.IsSuccessStatusCode;
		}
	}
}
