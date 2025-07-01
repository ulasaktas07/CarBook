using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.WriterDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class WriterApiClient(IHttpClientFactory httpClientFactory) : IWriterApiClient
	{
		public async Task<bool> DeleteWriterAsync(int id)
		{

			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/Writers/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return true;
		}

		public async Task<UpdateWriterRequest> GetWriteForUpdateAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/Writers/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateWriterRequest()!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateWriterRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdateWriterRequest()!;
		}

		public async Task<List<WriterDto>> GetWritersAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Writers");

			if (!response.IsSuccessStatusCode)
				return new List<WriterDto>();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<WriterDto>>(jsonData);

			return apiResponse?.Data ?? new List<WriterDto>();
		}

		public async Task<CreateWriterResult> SendCreateWriterAsync(CreateWriterRequest request)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(request);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Writers", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateWriterResult>(jsonData);
			return apiResponse!;
		}

		public async Task<UpdateWriterRequest> SendUpdateWriterAsync(UpdateWriterRequest request)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(request);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PutAsync("https://localhost:7274/api/Writers", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<UpdateWriterRequest>(jsonData);
			return apiResponse!;
		}
	}
}
