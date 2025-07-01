namespace CarBook.Dto.BannerDtos
{
	public class BannerDto
	{
		public int Id { get; set; }
		public string Title { get; set; } = default!;
		public string? Description { get; set; }
		public string? VideoDescription { get; set; }
		public string? VideoUrl { get; set; }
	}
}
