namespace CarBook.Dto.AboutDtos
{
	public class CreateAboutResult
	{
		public string Title { get; set; } = default!;
		public string Description { get; set; } = default!;
		public string? ImageUrl { get; set; }
	}
}
