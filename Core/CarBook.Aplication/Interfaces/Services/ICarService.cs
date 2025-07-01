using CarBook.Dto.CarDtos;

namespace CarBook.Aplication.Interfaces.Services;

public interface ICarService
{
	Task<bool> CreateCarAsync(CreateCarRequest request);

	Task<bool> UpdateCarAsync(UpdateCarRequest result);

}
