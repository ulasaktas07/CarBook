using CarBook.Aplication.Interfaces;

namespace CarBook.Persistence
{
	public class UnitOfWork(CarBookContext context) : IUnitOfWork
	{
		public Task<int> SaveChangesAsync()=>context.SaveChangesAsync();
	}
}
