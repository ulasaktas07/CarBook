namespace CarBook.Dto.AboutDtos
{
	public class CreateAboutRequest
	{
		public string Title { get; set; } = default!;
		public string Description { get; set; } = default!;
		public string? ImageUrl { get; set; }
	}
}
