using CarBook.Aplication.Interfaces.CarDescriptionInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
	public class CarDescriptionRepository(CarBookContext context) : ICarDescriptionRepository
	{
		public Task<CarDescription> CarDescriptionGetByCarIdAsync(int carid)
			=> context.CarDescriptions.FirstOrDefaultAsync(x => x.CarId == carid)!;
	}
}
