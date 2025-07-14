using CarBook.Aplication.Interfaces.CarFeatureInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
	public class CarFeatureRepository(CarBookContext context) : ICarFeatureRepository
	{
		public async Task<CarFeature> ChangeCarFeatureAvailableToFalseAsync(int id)
		{
			var carFeature = await context.CarFeatures.Where(x => x.Id == id).FirstOrDefaultAsync();
			carFeature!.Available = false;
			return carFeature!;

		}

		public async Task<CarFeature> ChangeCarFeatureAvailableToTrueAsync(int id)
		{
			var carFeature = await context.CarFeatures.Where(x => x.Id == id).FirstOrDefaultAsync();
			carFeature!.Available = true;
			return carFeature!;
		}

		public async Task<List<CarFeature>> GetCarFeaturesByCarIdAsync(int carID)
			=> await context.CarFeatures.Include(x=>x.Feature).Where(cf => cf.CarId == carID).ToListAsync();
	}
}
