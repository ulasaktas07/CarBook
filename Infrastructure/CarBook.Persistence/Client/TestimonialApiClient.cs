using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.TestimonialDtos;
using CarBook.Dto.TestimonialDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class TestimonialApiClient(IHttpClientFactory httpClientFactory) : ITestimonialApiClient
	{
		public async Task<bool> DeleteTestimonialAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/Testimonials/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return true;
		}

		public async Task<UpdateTestimonialRequest> GetTestimonialForUpdateAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Testimonials/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateTestimonialRequest()!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateTestimonialRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdateTestimonialRequest()!;
		}

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

		public async Task<CreateTestimonialResult> SendCreateTestimonialAsync(CreateTestimonialRequest createTestimonialRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createTestimonialRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Testimonials", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateTestimonialResult>(jsonData);
			return apiResponse!;
		}

		public async Task<UpdateTestimonialRequest> SendUpdateTestimonialAsync(UpdateTestimonialRequest updateTestimonialRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(updateTestimonialRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PutAsync($"https://localhost:7274/api/Testimonials/", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<UpdateTestimonialRequest>(jsonData);
			return apiResponse!;
		}
	}

}
