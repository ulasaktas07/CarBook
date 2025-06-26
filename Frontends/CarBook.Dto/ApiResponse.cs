namespace CarBook.Dto
{
	public class ApiResponse<T> where T : class
	{
		public List<T> Data { get; set; } = default!;
		public string? ErrorMessage { get; set; }
	}
}
