
using CarBook.Dto.ServiceDtos;

namespace CarBook.Dto.TagCloudDtos
{
	public class TagCloudByBlogIdDto
	{
		public int Id { get; set; }
		public string Title { get; set; } = default!;
		public int BlogID { get; set; }
	}
}
