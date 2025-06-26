using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Aplication.Interfaces;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Services
{
	public class ContactApiClient(IHttpClientFactory httpClientFactory) : IContactApiClient
	{
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
