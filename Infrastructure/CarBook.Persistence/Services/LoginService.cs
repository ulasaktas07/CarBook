using AutoMapper;
using CarBook.Aplication.Features.Mediator.Queries.AppUserQueries;
using CarBook.Aplication.Features.Mediator.Results.AppUserResults;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.LoginDtos;
using CarBook.WebUI.Models;
namespace CarBook.Persistence.Services
{
	public class LoginService(ILoginApiClient loginApiClient, IMapper mapper) : ILoginService
	{
		public async Task<JwtResponseModel> CreateLoginAsync(CreateLoginRequest createLoginRequest)
		{
			var command = mapper.Map<GetCheckAppUserQuery>(createLoginRequest);
			return await loginApiClient.SendCreateLoginAsync(createLoginRequest);
		}
	}
}
