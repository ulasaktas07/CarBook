using CarBook.Dto.BrandDtos;

namespace CarBook.Aplication.Services;

public interface IBrandService
{
	Task<bool> CreateBrandAsync(CreateBrandRequest createBrandRequest);
	Task<bool> UpdateBrandAsync(UpdateBrandRequest updateBrandRequest);

}
