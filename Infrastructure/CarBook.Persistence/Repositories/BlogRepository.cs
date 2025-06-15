using CarBook.Aplication.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
	public class BlogRepository(CarBookContext context) : IBlogRepository
	{
	

		public Task<List<Blog>> GetBlogsLast3WithWriters() =>
			context.Blogs.Include(b => b.Writer).OrderByDescending(b => b.Id).Take(3).ToListAsync();
	}
}
