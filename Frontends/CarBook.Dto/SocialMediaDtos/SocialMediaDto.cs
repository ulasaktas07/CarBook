namespace CarBook.Dto.SocialMediaDtos
{
	public class SocialMediaDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = default!;
		public string Url { get; set; } = default!;
		public string? Icon { get; set; }
	}
}
