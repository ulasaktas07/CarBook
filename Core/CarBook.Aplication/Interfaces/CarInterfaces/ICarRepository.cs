using CarBook.Domain.Entities;

namespace CarBook.Aplication.Interfaces.CarInterfaces
{
	public interface ICarRepository
	{
		List<Car> GetCarsListWithBrands();
		List<Car> GetCarsLast5WithBrands();
		Task<Car?> GetCarsListWithBrands(int id);
	}
}
