using CarBook.Aplication.Features.Mediator.Results.CarPricingResults;
using CarBook.Aplication.Interfaces.CarPricingInterfaces;
using CarBook.Aplication.ViewModels;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
	public class CarPricingRepository(CarBookContext context) : ICarPricingRepository
	{
		public Task<List<CarPricing>> GetCarPricingWithCars() => context.CarPricings.Include(c => c.Car).ThenInclude(c => c.Brand).
			Include(c => c.Pricing).Where(x => x.PricingId == 2).ToListAsync();

		public async Task<List<CarPricingViewModel>> GetCarPricingWithTimePeriod()
		{
			var results = await context.CarPricings
				.GroupBy(x => x.Car.Model)
				.Select(g => new CarPricingViewModel
				{
					Model = g.Key.ToString(),
					Amounts = new List<decimal>
					{
				g.Where(x => x.PricingId == 2).Sum(x => x.Price),  // Daily
                g.Where(x => x.PricingId == 3).Sum(x => x.Price),  // Weekly
                g.Where(x => x.PricingId == 4).Sum(x => x.Price)   // Monthly
					}
				})
				.ToListAsync();

			return results;	
		}
	}
}

