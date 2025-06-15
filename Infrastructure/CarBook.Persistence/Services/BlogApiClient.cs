using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.BlogDtos;
namespace CarBook.Persistence.Services
{
	public class BlogApiClient(IHttpClientFactory httpClientFactory) : IBlogApiClient
	{
		public async Task<List<Last3BlogsWithWriterDto>> GetLast3BlogsWithWriterAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Blogs/GetLast3BlogsWithWriters");
			if (!response.IsSuccessStatusCode)
				return new List<Last3BlogsWithWriterDto>();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<Last3BlogsWithWriterDto>>(jsonData);
			return apiResponse?.Data ?? new List<Last3BlogsWithWriterDto>();
		}
	}
}
