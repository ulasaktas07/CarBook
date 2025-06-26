
namespace CarBook.Dto.WriterDtos
{
	public class WriterByBlogWriterDto
	{
		public int Id { get; set; }
		public string WriterName { get; set; } = default!;
		public string WriterDescription { get; set; } = default!;
		public string? WriterImageUrl { get; set; }
		public int WriterID { get; set; }
	}
}
