using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto.RegisterDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class RegisterApiClient(IHttpClientFactory httpClientFactory) : IRegisterApiClient
	{
		public async Task<CreateRegisterResult> SendCreateRegisterAsync(CreateRegisterRequest createRegisterRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createRegisterRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Registers", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateRegisterResult>(jsonData);
			return apiResponse!;
		}
	}
}
