using CarBook.Domain.Entities;
using System.Linq.Expressions;

namespace CarBook.Aplication.Interfaces.RentACarInterfaces
{
	public interface IRentACarRepository
	{
		Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter);

	}
}
