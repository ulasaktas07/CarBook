
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Interfaces.CommentInterfaces
{
	public interface ICommentRepository
	{
		Task<List<Comment>> GetCommentsByBlogId(int id);
		Task<int> GetCommentCountByBlogId(int id);

	}
}
