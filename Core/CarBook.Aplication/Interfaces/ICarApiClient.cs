using CarBook.Dto.CarDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface ICarApiClient
	{
		Task<List<CarDto>> GetCarsAsync();
	}
}
