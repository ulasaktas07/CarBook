using CarBook.Domain.Entities;

namespace CarBook.Aplication.Interfaces
{
	public interface ICarRepository
	{
		List<Car> GetCarsListWithBrands();
	}
}
