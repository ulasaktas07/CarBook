using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
	public class CarRepository(CarBookContext context) : ICarRepository
	{
		public List<Car> GetCarsListWithBrands() => context.Cars.Include(c => c.Brand).ToList();

	}
}
