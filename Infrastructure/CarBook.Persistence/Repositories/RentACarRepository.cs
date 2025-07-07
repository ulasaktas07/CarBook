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
			return await context.RentACars.Where(filter).ToListAsync();
		}
	}
}
