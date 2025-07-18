using CarBook.Aplication.Interfaces.AppUserInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CarBook.Persistence.Repositories
{
	public class AppUserRepository(CarBookContext context) : IAppUserRepository
	{
		public async Task<AppUser?> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
		{
			return await context.AppUsers.Where(filter).FirstOrDefaultAsync();
		}
	}
}
