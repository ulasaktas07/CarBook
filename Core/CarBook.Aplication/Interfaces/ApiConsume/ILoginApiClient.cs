using CarBook.Dto.LoginDtos;
using CarBook.WebUI.Models;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface ILoginApiClient
	{
		Task<JwtResponseModel> SendCreateLoginAsync(CreateLoginRequest createLoginRequest);

	}
}
