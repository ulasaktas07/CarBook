using CarBook.Aplication.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
	public class CarRepository(CarBookContext context) : ICarRepository
	{
		public List<Car> GetCarsLast5WithBrands() => context.Cars.Include(c => c.Brand).OrderByDescending(c => c.Id).Take(5).ToList();

		public List<Car> GetCarsListWithBrands() => context.Cars.Include(c => c.Brand).ToList();

	}
}
