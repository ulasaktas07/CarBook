namespace CarBook.Dto.BlogDtos
{
	public class BlogWithWriterDto : ApiResponse<BlogWithWriterDto>
	{

		public int id { get; set; }
		public string title { get; set; } = default!;
		public string writerName { get; set; } = default!;
		public string categoryName { get; set; } = default!;
		public int writerID { get; set; }
		public string coverImageUrl { get; set; } = default!;
		public int categoryID { get; set; }
		public DateTime created { get; set; }
		public string description { get; set; }=default!;
		public string Description { get; set; } = default!;
		public string? ImageUrl { get; set; }
	}
}
