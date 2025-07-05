using CarBook.Dto.AboutDtos;

namespace CarBook.Aplication.Services
{
	public interface IAboutService
	{
		Task<CreateAboutResult> CreateAboutAsync(CreateAboutRequest createAboutRequest);

		Task<UpdateAboutRequest> UpdateAboutAsync(UpdateAboutRequest updateAboutRequest);
	}
}
