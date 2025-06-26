using CarBook.Aplication.Features.CQRS.Results.BannerResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Features.CQRS.Handlers.BannerHandlers
{
	public class GetBannerQueryHandler(IRepository<Banner> repository)
	{

		public async Task<ServiceResult<List<GetBannerQueryResult>>> Handle()
		{
			var banner = await repository.GetAllAsync();
			var values = banner.Select(b=>new GetBannerQueryResult(b.Id, b.Title, b.Description, b.VideoDescription, b.VideoUrl)).ToList();
			return ServiceResult<List<GetBannerQueryResult>>.Success(values);

		}
	}
}
