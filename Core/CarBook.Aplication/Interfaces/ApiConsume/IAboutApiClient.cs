using CarBook.Dto.AboutDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface IAboutApiClient
	{
		Task<List<AboutDto>> GetAboutsAsync();
	}
}
