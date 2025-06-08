using CarBook.Aplication.Features.CQRS.Results.CategoryResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Features.CQRS.Handlers.CategoryHandlers
{
	public class GetCategoryQueryHandler(IRepository<Category> repository)
	{
		public async Task<ServiceResult<List<GetCategorQueryResult>>> Handle()
		{
			var categories = await repository.GetAllAsync();
			var result = categories.Select(c => new GetCategorQueryResult(c.Id, c.Name)).ToList();

			return ServiceResult<List<GetCategorQueryResult>>.Success(result);
		}
	}
}
