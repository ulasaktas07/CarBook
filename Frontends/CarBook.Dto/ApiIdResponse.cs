namespace CarBook.Dto
{
	public class ApiIdResponse<T> where T : class
	{
		public T? Data { get; set; }
		public string? ErrorMessage { get; set; }
	}
}
