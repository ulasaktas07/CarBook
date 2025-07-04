namespace CarBook.Dto.TestimonialDtos
{
	public class UpdateTestimonialRequest
	{
		public int Id { get; set; }
		public string Name { get; set; } = default!;
		public string Title { get; set; } = default!;
		public string? Comment { get; set; }
		public string? ImageUrl { get; set; }
	}
}
