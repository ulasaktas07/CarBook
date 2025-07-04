using CarBook.Dto.SocialMediaDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface ISocialMediaApiClient
	{
		Task<List<SocialMediaDto>> GetSocialMediasAsync();

		Task<CreateSocialMediaResult> SendCreateSocialMediaAsync(CreateSocialMediaRequest createSocialMediaRequest);

		Task<UpdateSocialMediaRequest> GetSocialMediaForUpdateAsync(int id);

		Task<UpdateSocialMediaRequest> SendUpdateSocialMediaAsync(UpdateSocialMediaRequest updateSocialMediaRequest);

		Task<bool> DeleteSocialMediaAsync(int id);

	}
}
