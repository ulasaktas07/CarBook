using CarBook.Dto.BannerDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface IBannerApiClient
	{
		Task<List<BannerDto>> GetBannersAsync();

		Task<CreateBannerResult> SendCreateBannerAsync(CreateBannerRequest request);

		Task<bool> DeleteBannerAsync(int id);
		Task<UpdateBannerRequest> GetBannerForUpdateAsync(int id);
		Task<UpdateBannerRequest> SendUpdateBannerAsync(UpdateBannerRequest request);
	}
}
