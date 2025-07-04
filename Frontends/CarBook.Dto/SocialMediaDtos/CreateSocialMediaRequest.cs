namespace CarBook.Dto.SocialMediaDtos
{
	public class CreateSocialMediaRequest
	{
		public string Name { get; set; } = default!;
		public string Url { get; set; } = default!;
		public string? Icon { get; set; }
	}
}
