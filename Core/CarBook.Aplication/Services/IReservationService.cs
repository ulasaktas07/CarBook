using CarBook.Dto.ReservationDtos;

namespace CarBook.Aplication.Services
{
	public interface IReservationService
	{
		Task<CreateReservationResult> CreateReservationAsync(CreateReservationRequest createReservationRequest);

	}
}
