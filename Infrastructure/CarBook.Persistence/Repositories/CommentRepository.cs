using CarBook.Aplication.Interfaces.CommentInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
	public class CommentRepository(CarBookContext context) : ICommentRepository
	{
		public Task<int> GetCommentCountByBlogId(int id)=>
			context.Comments.CountAsync(c => c.Blog.Id == id);

		public Task<List<Comment>> GetCommentsByBlogId(int id)=>
			context.Comments.Where(c => c.Blog.Id == id).ToListAsync();
	}
}
