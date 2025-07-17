namespace CarBook.Dto.ReviewDtos
{
	public class ReviewByCarIdDto
	{
		public int Id { get; set; }
		public string CustomerName { get; set; } = default!;
		public string? CustomerImage { get; set; }
		public string Comment { get; set; } = default!;
		public int RaytingValue { get; set; }
		public int CarID { get; set; }
		public DateTime Created { get; set; }
	}
}
