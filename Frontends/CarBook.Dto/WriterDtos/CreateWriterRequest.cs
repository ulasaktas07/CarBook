namespace CarBook.Dto.WriterDtos
{
	public class CreateWriterRequest
	{
		public string Name { get; set; } = default!;
		public string Description { get; set; } = default!;
		public string? ImageUrl { get; set; }
	}
}
