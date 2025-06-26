
using CarBook.Dto.ServiceDtos;

namespace CarBook.Dto.TagCloudDtos
{
	public class TagCloudByBlogIdDto: ApiResponse<TagCloudByBlogIdDto>
	{
		public int Id { get; set; }
		public string Title { get; set; } = default!;
		public int BlogID { get; set; }
	}
}
