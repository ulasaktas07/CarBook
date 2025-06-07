using CarBook.Aplication.Features.CQRS.Results.BrandResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Features.CQRS.Handlers.BrandHandlers
{
	public class GetBrandQueryHandler(IRepository<Brand> repository)
	{
		public async Task<ServiceResult<List<GetBrandQueryResult>>> Handle()
		{
			var brands = await repository.GetAllAsync();
			var values = brands.Select(b => new GetBrandQueryResult(b.Id, b.Name)).ToList();
			return ServiceResult<List<GetBrandQueryResult>>.Success(values);
		}

	}
}
