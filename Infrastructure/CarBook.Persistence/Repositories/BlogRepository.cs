using CarBook.Aplication.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
	public class BlogRepository(CarBookContext context) : IBlogRepository
	{
		public Task<Blog> GetWriterByBlogId(int id)=> context.Blogs.Include(b => b.Writer).FirstOrDefaultAsync(b => b.Id == id)!;

		public Task<List<Blog>> GetBlogsLast3WithWriters() =>
			context.Blogs.Include(b => b.Writer).OrderByDescending(b => b.Id).Take(3).ToListAsync();

		public Task<List<Blog>> GetBlogsWithWriters()=>
			context.Blogs.Include(b => b.Writer).Include(b=>b.Category).ToListAsync();
	}
}
