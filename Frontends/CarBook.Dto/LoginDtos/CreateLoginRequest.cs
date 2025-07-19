namespace CarBook.Dto.LoginDtos
{
	public class CreateLoginRequest
	{
		public string UserName { get; set; } = default!;
		public string Password { get; set; } = default!;
	}
}
