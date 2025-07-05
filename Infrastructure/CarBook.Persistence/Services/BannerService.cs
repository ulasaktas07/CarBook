using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.BannerCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Services;
using CarBook.Dto.BannerDtos;

namespace CarBook.Persistence.Services
{
	public class BannerService(IBannerApiClient bannerApiClient, IMapper mapper) : IBannerService
	{
		public async Task<CreateBannerResult> SendCreateBannerAsync(CreateBannerRequest request)
		{
			var command = mapper.Map<CreateBannerCommand>(request);
			return await bannerApiClient.SendCreateBannerAsync(request);
		}

		public async Task<UpdateBannerRequest> UpdateBannerAsync(UpdateBannerRequest request)
		{
			var command = mapper.Map<UpdateBannerCommand>(request);
			var result = await bannerApiClient.SendUpdateBannerAsync(request);
			if (result == null)
			{
				return null!;
			}
			return mapper.Map<UpdateBannerRequest>(result);
		}
	}
}
