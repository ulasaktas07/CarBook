using CarBook.Dto.SocialMediaDtos;

namespace CarBook.Aplication.Services
{
	public interface ISocialMediaService
	{
		Task<CreateSocialMediaResult> CreateSocialMediaAsync(CreateSocialMediaRequest createSocialMediaRequest);

		Task<UpdateSocialMediaRequest> UpdateSocialMediaAsync(UpdateSocialMediaRequest updateSocialMediaRequest);
	}
}
