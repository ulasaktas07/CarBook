using CarBook.Aplication.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CarBook.Persistence.Repositories
{
	public class Repository<T>(CarBookContext context) : IRepository<T> where T : class
	{
		private readonly DbSet<T> _dbSet = context.Set<T>();
		public async Task CreateAsync(T entity)=>await _dbSet.AddAsync(entity);

		public async Task<List<T>> GetAllAsync() => await _dbSet.ToListAsync();

		public async Task<T?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

		public void Remove(T entity) => _dbSet.Remove(entity);

		public void Update(T entity) => _dbSet.Update(entity);
		public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate) => _dbSet.AnyAsync(predicate);

		public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> predicate)
			=> await context.Set<T>().SingleOrDefaultAsync(predicate);
	}
}
