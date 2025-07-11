using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto.ReservationDtos;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.Persistence.Client
{
	public class ReservationApiClient(IHttpClientFactory httpClientFactory) : IReservationApiClient
	{
		public async Task<CreateReservationResult> SendCreateReservationAsync(CreateReservationRequest createReservationRequest)
		{
			var client = httpClientFactory.CreateClient();
			var jsonContent = JsonConvert.SerializeObject(createReservationRequest);
			var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7274/api/Reservations", content);
			if (!response.IsSuccessStatusCode)
				return null!;
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<CreateReservationResult>(jsonData);
			return apiResponse!;
		}
	}
}
