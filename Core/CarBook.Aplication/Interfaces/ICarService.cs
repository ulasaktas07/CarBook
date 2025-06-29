using CarBook.Dto.CarDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface ICarService
	{
		Task<bool> CreateCarAsync(CreateCarRequest request);

		Task<bool> UpdateCarAsync(UpdateCarRequest result);

	}
}
