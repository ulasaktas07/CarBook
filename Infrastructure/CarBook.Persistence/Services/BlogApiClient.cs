using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.BlogDtos;
using CarBook.Dto.WriterDtos;
using Newtonsoft.Json;
namespace CarBook.Persistence.Services
{
	public class BlogApiClient(IHttpClientFactory httpClientFactory) : IBlogApiClient
	{
		public async Task<List<BlogWithWriterDto>> GetAllBlogsWithWriterAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Blogs/GetAllBlogsWithWriters");
			if (!response.IsSuccessStatusCode)
				return new List<BlogWithWriterDto>();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<BlogWithWriterDto>>(jsonData);
			return apiResponse?.Data ?? new List<BlogWithWriterDto>();
		}

		public async Task<BlogByIdDto> GetBlogByIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Blogs/"+id);

			if (!response.IsSuccessStatusCode)
				return new BlogByIdDto();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<BlogByIdDto>>(jsonData);

			return apiResponse?.Data ?? new BlogByIdDto();
		}
		public async Task<List<Last3BlogsWithWriterDto>> GetLast3BlogsWithWriterAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Blogs/GetLast3BlogsWithWriters");
			if (!response.IsSuccessStatusCode)
				return new List<Last3BlogsWithWriterDto>();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Last3BlogsWithWriterDto>>(jsonData);
			return apiResponse?.Data ?? new List<Last3BlogsWithWriterDto>();
		}

		public async Task<WriterByBlogWriterDto> GetWriterByBlogIdAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Blogs/GetBlogByWriterId?id=" +id);
			if (!response.IsSuccessStatusCode)
				return new WriterByBlogWriterDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<WriterByBlogWriterDto>>(jsonData);
			return apiResponse?.Data ?? new WriterByBlogWriterDto();
		}
	}
}
