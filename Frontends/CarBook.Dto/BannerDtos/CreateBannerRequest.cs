namespace CarBook.Dto.BannerDtos
{
	public class CreateBannerRequest
	{
		public string Title { get; set; } = default!;
		public string? Description { get; set; }
		public string? VideoDescription { get; set; }
		public string? VideoUrl { get; set; }
	}
}
