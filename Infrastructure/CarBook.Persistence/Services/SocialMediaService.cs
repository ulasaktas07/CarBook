using AutoMapper;
using CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommands;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.SocialMediaDtos;

namespace CarBook.Persistence.Services
{
	public class SocialMediaService(ISocialMediaApiClient socialMediaApiClient, IMapper mapper) : ISocialMediaService
	{
		public async Task<CreateSocialMediaResult> CreateSocialMediaAsync(CreateSocialMediaRequest createSocialMediaRequest)
		{
			var command = mapper.Map<CreateSocialMediaCommand>(createSocialMediaRequest);
			return await socialMediaApiClient.SendCreateSocialMediaAsync(createSocialMediaRequest);
		}

		public async Task<UpdateSocialMediaRequest> UpdateSocialMediaAsync(UpdateSocialMediaRequest updateSocialMediaRequest)
		{
			var command = mapper.Map<UpdateSocialMediaCommand>(updateSocialMediaRequest);
			return await socialMediaApiClient.SendUpdateSocialMediaAsync(updateSocialMediaRequest);
		}
	}
}
