using CarBook.Domain.Entities;
namespace CarBook.Aplication.Interfaces.TagCloudInterfaces
{
	public interface ITagCloudRepository
	{
		Task<List<TagCloud>> GetTagCloudsByBlogIdAsync(int id);
	}
}
