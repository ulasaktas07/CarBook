namespace CarBook.Dto.RegisterDtos
{
	public class CreateRegisterRequest
	{
		public string UserName { get; set; } = default!;
		public string Password { get; set; } = default!;
		public string Name { get; set; } = default!;
		public string Surname { get; set; } = default!;
		public string Email { get; set; } = default!;
	}
}
