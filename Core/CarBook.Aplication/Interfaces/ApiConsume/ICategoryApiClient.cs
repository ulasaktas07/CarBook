using CarBook.Dto.CategoryDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface ICategoryApiClient
	{
		Task<List<CategoryDto>> GetCategoryAsync();

	}
}
