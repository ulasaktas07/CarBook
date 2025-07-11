using CarBook.Dto.ReservationDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface IReservationApiClient
	{
		Task<CreateReservationResult> SendCreateReservationAsync(CreateReservationRequest createReservationRequest);
	}
}
