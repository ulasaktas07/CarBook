using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.FooterAddressDtos;
using Newtonsoft.Json;

namespace CarBook.Persistence.Services
{
	public class FooterAddressApiClient : IFooterAddressApiClient
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
	}
}
