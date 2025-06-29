using CarBook.Dto.CarDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface ICarApiClient
	{
		Task<List<CarDto>> GetCarsAsync();
		Task<List<Last5CarsWithBrandsDto>> GetLast5CarsWithBrandsAsync();
		Task<List<CarDto>> GetCarsWithBrandAsync();
		Task<bool> SendCreateCarAsync(CreateCarRequest request);
		Task<bool> SendDeleteCarAsync(int id);

		Task<ResultCarDto> GetByIdAsync(int id);

		Task<bool> SendUpdateCarAsync(ResultCarDto result);


	}
}
