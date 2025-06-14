using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.AboutDtos;
using CarBook.Dto.TestimonialDtos;
using Newtonsoft.Json;

namespace CarBook.Persistence.Services
{
	public class TestimonialApiClient(IHttpClientFactory httpClientFactory) : ITestimonialApiClient
	{
		public async Task<List<TestimonialDto>> GetTestimonialsAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Testimonials");

			if (!response.IsSuccessStatusCode)
				return new List<TestimonialDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<TestimonialDto>>(jsonData);

			return apiResponse?.Data ?? new List<TestimonialDto>();

		}
	}

}
