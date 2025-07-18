using AutoMapper;
using CarBook.Aplication.Features.Mediator.Commands.AppUserCommands;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.RegisterDtos;

namespace CarBook.Persistence.Services
{
	public class RegisterService(IRegisterApiClient RegisterApiClient, IMapper mapper) : IRegisterService
	{
		public async Task<CreateRegisterResult> CreateRegisterAsync(CreateRegisterRequest createRegisterRequest)
		{
			var command = mapper.Map<CreateAppUserCommand>(createRegisterRequest);
			return await RegisterApiClient.SendCreateRegisterAsync(createRegisterRequest);
		}
	}
}
