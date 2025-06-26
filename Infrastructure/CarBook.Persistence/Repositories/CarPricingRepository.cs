using CarBook.Aplication.Interfaces.CarPricingInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
	public class CarPricingRepository(CarBookContext context) : ICarPricingRepository
	{
		public Task<List<CarPricing>> GetCarPricingWithCars() => context.CarPricings.Include(c => c.Car).ThenInclude(c => c.Brand).
			Include(c => c.Pricing).Where(x=>x.PricingId==2).ToListAsync();
	}
}

