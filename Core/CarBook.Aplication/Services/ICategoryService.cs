using CarBook.Dto.CategoryDtos;

namespace CarBook.Aplication.Services
{
	public interface ICategoryService
	{
		Task<CreateCategoryResult> CreateCategoryAsync(CreateCategoryRequest request);
		Task<UpdateCategoryRequest> UpdateCategoryAsync(UpdateCategoryRequest request);
	}
}
