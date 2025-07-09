using CarBook.Dto.RentACarDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface IRentACarApiClient
	{
		Task<List<FilterRentACarDto>> GetAvailableRentACarsAsync(int id );
	}
}
