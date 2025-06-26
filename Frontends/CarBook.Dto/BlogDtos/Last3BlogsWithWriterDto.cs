namespace CarBook.Dto.BlogDtos
{
	public class Last3BlogsWithWriterDto : ApiResponse<Last3BlogsWithWriterDto>
	{
		public int Id { get; set; }
		public string Title { get; set; } = default!;
		public int WriterID { get; set; }
		public string WriterName { get; set; } = default!;
		public string CoverImageUrl { get; set; } = default!;
		public int CategoryID { get; set; }
		public DateTime Created { get; set; }

	}
}
