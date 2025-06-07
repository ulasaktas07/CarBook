namespace CarBook.Aplication.Interfaces
{
	public interface IUnitOfWork
	{
		Task<int> SaveChangesAsync();
	}
}
