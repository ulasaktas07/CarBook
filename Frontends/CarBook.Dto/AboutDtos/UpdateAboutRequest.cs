namespace CarBook.Dto.AboutDtos
{
	public class UpdateAboutRequest
	{
		public int Id { get; set; }
		public string Title { get; set; } = default!;
		public string Description { get; set; } = default!;
		public string? ImageUrl { get; set; }
	}
}
