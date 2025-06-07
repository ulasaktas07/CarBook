namespace CarBook.Aplication.Interfaces
{
	public interface IRepository<T> where T:class
	{
		Task<List<T>> GetAllAsync();
		Task<T?> GetByIdAsync(int id);
		Task CreateAsync(T entity);
		void Update(T entity);
		void Remove(T entity);
	}
}
