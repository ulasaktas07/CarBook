using CarBook.Domain.Entities;
using System.Linq.Expressions;

namespace CarBook.Aplication.Interfaces.AppUserInterfaces
{
	public interface IAppUserRepository
	{
		Task<AppUser?> GetByFilterAsync(Expression<Func<AppUser, bool>> filter);

	}
}
