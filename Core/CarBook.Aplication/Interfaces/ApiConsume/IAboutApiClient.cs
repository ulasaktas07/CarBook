using CarBook.Dto.AboutDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface IAboutApiClient
	{
		Task<List<AboutDto>> GetAboutsAsync();

		Task<CreateAboutResult> SendCreateAboutAsync(CreateAboutRequest createAboutRequest);

		Task<UpdateAboutRequest> GetAboutForUpdateAsync(int id);

		Task<UpdateAboutRequest> SendUpdateAboutAsync(UpdateAboutRequest updateAboutRequest);	

		Task<bool> DeleteAboutAsync(int id);


	}
}
