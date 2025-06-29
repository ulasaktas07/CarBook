using CarBook.Dto.BrandDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface IBrandService
	{
		Task<bool> CreateBrandAsync(CreateBrandRequest createBrandRequest);
		Task<bool> UpdateBrandAsync(UpdateBrandRequest updateBrandRequest);

	}
}
