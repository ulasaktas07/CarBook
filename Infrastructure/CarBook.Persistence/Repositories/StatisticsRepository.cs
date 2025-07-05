using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
	public class StatisticsRepository(CarBookContext context) : IStatisticsRepository
	{
		public async Task<string?> GetBlogTitleByMaxBlogCommentAsync()=>await context.Blogs
			.Include(x => x.Comments)
			.OrderByDescending(x => x.Comments!.Count)
			.Select(x => x.Title)
			.FirstOrDefaultAsync();

		public async Task<string?> GetBrandNameByMaxCarAsync()=> await context.Cars
			.GroupBy(x => x.Brand.Name)
			.OrderByDescending(g => g.Count())
			.Select(g => g.Key)
			.FirstOrDefaultAsync();


		public async Task<decimal> GetAvrgRentPriceForDailyAsync()=> await context.CarPricings
			.Where(x => x.PricingId == context.Pricing.Where(x => x.Name == "Günlük")
			.Select(x => x.Id).FirstOrDefault()).AverageAsync(x => x.Price);

		public async Task<decimal> GetAvrgRentPriceForMonthlyAsync() => await context.CarPricings.
			Where(x => x.PricingId == context.Pricing.Where(x => x.Name == "Aylık")
			.Select(x => x.Id).FirstOrDefault()).AverageAsync(x => x.Price);


		public async Task<decimal> GetAvrgRentPriceForWeeklyAsync()=> await context.CarPricings
			.Where(x => x.PricingId == context.Pricing.Where(x => x.Name == "Haftalık")
			.Select(x => x.Id).FirstOrDefault()).AverageAsync(x => x.Price);

		public Task<int> GetBlogCountAsync()=>context.Blogs.CountAsync();
		public Task<int> GetBrandCountAsync()=>context.Brands.CountAsync();

		public async Task<string?> GetCarBrandAndModelByRentPriceDailyMaxAsync()=>await context.Cars
			.Include(x => x.CarPricings)
			.Where(x => x.CarPricings.Any(cp => cp.Pricing.Name == "Günlük"))
			.OrderByDescending(x => x.CarPricings.FirstOrDefault(cp => cp.Pricing.Name == "Günlük")!.Price)
			.Select(x => $"{x.Brand.Name} {x.Model}")
			.FirstOrDefaultAsync();


		public async Task<string?> GetCarBrandAndModelByRentPriceDailyMinAsync()=>await context.Cars
			.Include(x => x.CarPricings)
			.Where(x => x.CarPricings.Any(cp => cp.Pricing.Name == "Günlük"))
			.OrderBy(x => x.CarPricings.FirstOrDefault(cp => cp.Pricing.Name == "Günlük")!.Price)
			.Select(x => $"{x.Brand.Name} {x.Model}")
			.FirstOrDefaultAsync();

		public Task<int> GetCarCountAsync()=>context.Cars.CountAsync();

		public Task<int> GetCarCountByFuelElectricAsync()=> context.Cars
			.Where(x => x.Fuel == "Elektrik").CountAsync();


		public Task<int> GetCarCountByFuelGasolineOrDieselAsync()=> context.Cars
			.Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel").CountAsync();

		public Task<int> GetCarCountByKmSmallerThan1000Async()=> context.Cars
			.Where(x => x.Km < 1000).CountAsync();


		public async Task<int> GetCarCountByTransmissionIsAutoAsync()=>await context.Cars
			.Where(x=>x.Transmission=="Otomatik").CountAsync();

		public Task<int> GetLocationCountAsync()=>context.Locations.CountAsync();

		public Task<int> GetWriterCountAsync()=>context.Writers.CountAsync();
	}
}
