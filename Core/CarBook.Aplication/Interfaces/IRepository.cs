using System.Linq.Expressions;

namespace CarBook.Aplication.Interfaces
{
	public interface IRepository<T> where T:class
	{
		Task<List<T>> GetAllAsync();
		Task<T?> GetByIdAsync(int id);
		Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
		Task CreateAsync(T entity);
		void Update(T entity);
		void Remove(T entity);

	}
}
