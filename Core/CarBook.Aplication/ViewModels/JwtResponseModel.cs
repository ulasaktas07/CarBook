namespace CarBook.WebUI.Models
{
	public class JwtResponseModel
	{
		public string Token { get; set; } = default!;
		public DateTime ExpireDate { get; set; } 
	}
}
