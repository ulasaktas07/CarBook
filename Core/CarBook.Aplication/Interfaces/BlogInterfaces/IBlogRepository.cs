using CarBook.Domain.Entities;

namespace CarBook.Aplication.Interfaces.BlogInterfaces
{
	public interface IBlogRepository
	{
	Task<List<Blog>> GetBlogsLast3WithWriters();

	}
}
