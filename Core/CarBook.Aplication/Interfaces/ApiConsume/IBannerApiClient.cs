using CarBook.Dto.AboutDtos;
using CarBook.Dto.BannerDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface IBannerApiClient
	{
		Task<List<BannerDto>> GetBannersAsync();

	}
}
