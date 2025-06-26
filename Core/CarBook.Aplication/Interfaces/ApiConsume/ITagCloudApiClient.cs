using CarBook.Dto.TagCloudDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface ITagCloudApiClient
	{
		Task<List<TagCloudByBlogIdDto>> GetTagCloudsByBlogIdAsync(int id);
	}
}
