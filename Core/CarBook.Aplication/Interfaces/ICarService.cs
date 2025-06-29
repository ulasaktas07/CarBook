using CarBook.Dto.CarDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface ICarService
	{
		Task<bool> CreateCarAsync(CreateCarRequest request);

		Task<bool> UpdateCarAsync(ResultCarDto result);

	}
}
