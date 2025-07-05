using CarBook.Dto.BannerDtos;

namespace CarBook.Aplication.Services;

public interface IBannerService
{
	Task<CreateBannerResult> SendCreateBannerAsync(CreateBannerRequest request);

	Task<UpdateBannerRequest> UpdateBannerAsync(UpdateBannerRequest request);

}
