using CarBook.Dto.AboutDtos;
using CarBook.Dto.CategoryDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface ICategoryApiClient
	{
		Task<List<CategoryDto>> GetCategoryAsync();

		Task<CreateCategoryResult> SendCreateCategoryAsync(CreateCategoryRequest request);

		Task<UpdateCategoryRequest> SendUpdateCategoryAsync(UpdateCategoryRequest request);

		Task<UpdateCategoryRequest> GetCategoryForUpdateAsync(int id);

		Task<bool> DeleteCategoryAsync(int id);


	}
}
