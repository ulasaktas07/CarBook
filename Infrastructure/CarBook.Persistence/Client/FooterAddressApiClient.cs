using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.FooterAddressDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class FooterAddressApiClient(IHttpClientFactory httpClientFactory) : IFooterAddressApiClient
	{
		public async Task<List<FooterAddressDto>> GetFooterAddressesAsync()
		{
			var client = new HttpClient();
			var response = await client.GetAsync("https://localhost:7274/api/FooterAddresses");
			if (!response.IsSuccessStatusCode)
				return new List<FooterAddressDto>();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse =JsonConvert.DeserializeObject<ApiResponse<FooterAddressDto>>(jsonData);
			return apiResponse?.Data ?? new List<FooterAddressDto>();
		}
		public async Task<bool> DeleteFooterAddressAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"https://localhost:7274/api/FooterAddresses/{id}");
			if (!response.IsSuccessStatusCode)
				return false;
			return true;
		}

		public async Task<UpdateFooterAddressRequest> GetFooterAddressForUpdateAsync(int id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync($"https://localhost:7274/api/FooterAddresses/{id}");
			if (!response.IsSuccessStatusCode)
				return new UpdateFooterAddressRequest()!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<UpdateFooterAddressRequest>>(jsonData);
			return apiResponse?.Data ?? new UpdateFooterAddressRequest()!;
		}
		public async Task<CreateFooterAddressResult> SendCreateFooterAddressAsync(CreateFooterAddressRequest createFooterAddressRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createFooterAddressRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/FooterAddresses", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateFooterAddressResult>(jsonData);
			return apiResponse!;
		}

		public async Task<UpdateFooterAddressRequest> SendUpdateFooterAddressAsync(UpdateFooterAddressRequest updateFooterAddressRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(updateFooterAddressRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PutAsync($"https://localhost:7274/api/FooterAddresses/", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<UpdateFooterAddressRequest>(jsonData);
			return apiResponse!;
		}
	}
}
