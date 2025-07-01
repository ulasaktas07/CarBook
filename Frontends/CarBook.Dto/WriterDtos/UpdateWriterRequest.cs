namespace CarBook.Dto.WriterDtos
{
	public class UpdateWriterRequest
	{
		public int Id { get; set; }
		public string Name { get; set; } = default!;
		public string Description { get; set; } = default!;
		public string? ImageUrl { get; set; }
	}
}
