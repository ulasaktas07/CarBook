using CarBook.Aplication.Features.CQRS.Queries.CategoryQueries;
using CarBook.Aplication.Features.CQRS.Results.CategoryResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.CategoryHandlers
{
	public class GetCategoryByIdQueryHandler(IRepository<Category> repository)
	{
		public async Task<ServiceResult<GetCategoryByIdQueryResult>> Handle(GetCategoryByIdQuery query)
		{
			var category = await repository.GetByIdAsync(query.Id);
			if (category is null) return ServiceResult<GetCategoryByIdQueryResult>.Fail("Kategori bulunamadı", HttpStatusCode.NotFound);

			var values = new GetCategoryByIdQueryResult(category.Id, category.Name);

			return ServiceResult<GetCategoryByIdQueryResult>.Success(values)!;
		}
	}
}
