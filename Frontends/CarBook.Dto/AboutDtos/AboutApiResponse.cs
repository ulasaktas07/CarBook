namespace CarBook.Dto.AboutDtos
{
	public class AboutApiResponse
	{
		public List<AboutDto> Data { get; set; } = new();
		public string? ErrorMessage { get; set; }
	}
}
