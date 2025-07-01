using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.AboutCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.AboutDtos;

namespace CarBook.Persistence.Services
{
	public class AboutService(IAboutApiClient aboutApiClient, IMapper mapper) : IAboutService
	{
		public async Task<CreateAboutResult> CreateAboutAsync(CreateAboutRequest createAboutRequest)
		{
			var command = mapper.Map<CreateAboutCommand>(createAboutRequest);
			return await aboutApiClient.SendCreateAboutAsync(createAboutRequest);
		}

		public async Task<UpdateAboutRequest> UpdateAboutAsync(UpdateAboutRequest updateAboutRequest)
		{
			var command = mapper.Map<UpdateAboutCommand>(updateAboutRequest);
			return await aboutApiClient.SendUpdateAboutAsync(updateAboutRequest);
		}
	}
}
