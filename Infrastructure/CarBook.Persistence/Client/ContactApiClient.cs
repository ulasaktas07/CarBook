using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.ContactDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class ContactApiClient(IHttpClientFactory httpClientFactory) : IContactApiClient
	{
		public async Task<List<ContactDto>> GetContactsAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Contacts");
			if (!response.IsSuccessStatusCode)
			{
				return new List<ContactDto>();
			}
			var json = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiResponse<ContactDto>>(json);
			return apiResponse?.Data ?? new List<ContactDto>();
		}

		public async Task<bool> SendCreateCommandAsync(CreateContactCommand command)
		{
			var client = httpClientFactory.CreateClient();

			var json = JsonConvert.SerializeObject(command);
			var content = new StringContent(json, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Contacts", content);
			return response.IsSuccessStatusCode;
		}
	}
}
