using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.TagCloudDtos;
using System.Net.Http.Json;

namespace CarBook.Persistence.Client
{
	public class TagCloudApiClient(IHttpClientFactory httpClientFactory) : ITagCloudApiClient
	{
		public async Task<List<TagCloudByBlogIdDto>> GetTagCloudsByBlogIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/TagClouds/GetTagCloudBlogId?blogId=" + id);
			if (!response.IsSuccessStatusCode)
				return new List<TagCloudByBlogIdDto>();

			var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<TagCloudByBlogIdDto>>();
			return apiResponse?.Data ?? new List<TagCloudByBlogIdDto>();
		}

	}
}
