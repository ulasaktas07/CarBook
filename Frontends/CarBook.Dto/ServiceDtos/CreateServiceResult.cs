namespace CarBook.Dto.ServiceDtos
{
	public class CreateServiceResult
	{
		public string Title { get; set; } = default!;
		public string? Description { get; set; }
		public string? IconUrl { get; set; }
	}
}
