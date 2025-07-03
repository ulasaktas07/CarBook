using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.BannerDtos;
using CarBook.Dto.CommentDtos;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace CarBook.Persistence.Client
{
	public class CommentApiClient(IHttpClientFactory httpClientFactory) : ICommentApiClient
	{
		public async Task<List<CommentDto>> GetCommentListByBlogIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient("CommentApiClient");
			var response = await client.GetAsync($"https://localhost:7274/api/Comments/CommentListByBlog?id=" + id);
			if (!response.IsSuccessStatusCode)
				return new List<CommentDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<CommentDto>>(jsonData);

			return apiResponse?.Data ?? new List<CommentDto>();


		}
	}
}
