
using CarBook.Dto.LoginDtos;
using CarBook.WebUI.Models;

namespace CarBook.Aplication.Services
{
	public interface ILoginService
	{
		Task<JwtResponseModel> CreateLoginAsync(CreateLoginRequest createLoginRequest);

	}
}
