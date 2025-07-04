namespace CarBook.Dto.SocialMediaDtos
{
	public class CreateSocialMediaResult
	{
		public string Name { get; set; } = default!;
		public string Url { get; set; } = default!;
		public string? Icon { get; set; }
	}
}
