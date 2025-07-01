namespace CarBook.Dto.WriterDtos
{
	public class CreateWriterResult
	{
		public string Name { get; set; } = default!;
		public string Description { get; set; } = default!;
		public string? ImageUrl { get; set; }
	}
}
