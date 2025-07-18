namespace CarBook.Aplication.Dtos
{
	public class TokenResponseDto
	{
		public string Token { get; set; }=default!;
		public DateTime ExpireDate { get; set; }


		public TokenResponseDto(string token, DateTime expireDate)
		{
			Token = token;
			ExpireDate = expireDate;

		}


	}
}
