namespace CarBook.Dto.ServiceDtos
{
	public class ServiceDto:ApiResponse<ServiceDto>
	{
		public int Id { get; set; }
		public string Title { get; set; } = default!;
		public string? Description { get; set; }
		public string? IconUrl { get; set; }
	}
}
