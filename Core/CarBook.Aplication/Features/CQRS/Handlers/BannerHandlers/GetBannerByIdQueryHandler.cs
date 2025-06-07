using CarBook.Aplication.Features.CQRS.Queries.BannerQueries;
using CarBook.Aplication.Features.CQRS.Results.BannerResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.BannerHandlers
{
	public class GetBannerByIdQueryHandler(IRepository<Banner> repository)
	{
		public async Task<ServiceResult<GetBannerByIdQueryResult>> Handle(GetBannerByIdQuery query)
		{
			var banner = await repository.GetByIdAsync(query.Id);
			if (banner == null)	return ServiceResult<GetBannerByIdQueryResult>.Fail("Banner bulunamadı",HttpStatusCode.NotFound);

			var result = new GetBannerByIdQueryResult(banner.Id, banner.Title, banner.Description, banner.VideoDescription, banner.VideoUrl);
			return ServiceResult<GetBannerByIdQueryResult>.Success(result);
		}
	}
}
