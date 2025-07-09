using CarBook.Aplication.Interfaces.RentACarInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CarBook.Persistence.Repositories
{
	public class RentACarRepository(CarBookContext context) : IRentACarRepository
	{
		public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
		{
			return await context.RentACars.Include(x => x.Car).ThenInclude(x => x.CarPricings).Include(x => x.Car)
				.ThenInclude(x => x.Brand).Where(filter).ToListAsync();
		}
	}
}
