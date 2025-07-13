using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.CommentDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class CommentApiClient(IHttpClientFactory httpClientFactory) : ICommentApiClient
	{
		public async Task<CommentCountByBlogIdDto> GetCommentCountByBlogIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Comments/CommentCountByBlogId?id=" + id);
			if (!response.IsSuccessStatusCode)
				return new CommentCountByBlogIdDto();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<CommentCountByBlogIdDto>>(jsonData);
			return apiResponse?.Data ?? new CommentCountByBlogIdDto();


		}

		public async Task<List<CommentDto>> GetCommentListByBlogIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Comments/CommentListByBlog?id=" + id);
			if (!response.IsSuccessStatusCode)
				return new List<CommentDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<CommentDto>>(jsonData);

			return apiResponse?.Data ?? new List<CommentDto>();


		}

		public async Task<CreateCommentResult> SendCreateCommentAsync(CreateCommentRequest createCommentRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createCommentRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Comments", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateCommentResult>(jsonData);
			return apiResponse!;
		}
	}
}
