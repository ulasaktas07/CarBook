using CarBook.Aplication.Features.CQRS.Queries.BrandQueries;
using CarBook.Aplication.Features.CQRS.Results.BannerResults;
using CarBook.Aplication.Features.CQRS.Results.BrandResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;
using System.Reflection;

namespace CarBook.Aplication.Features.CQRS.Handlers.BrandHandlers
{
	public class GetBrandByIdQueryHandler(IRepository<Brand> repository)
	{
		public async Task<ServiceResult<GetBrandByIdQueryResult>> Handle(GetBrandByIdQuery query)
		{
			var brand = await repository.GetByIdAsync(query.Id);
			if (brand == null) return ServiceResult<GetBrandByIdQueryResult>.Fail("Marka bulunamadı", HttpStatusCode.NotFound);

			var result = new GetBrandByIdQueryResult(brand.Id, brand.Name);
			return ServiceResult<GetBrandByIdQueryResult>.Success(result);
		}
	}
}
