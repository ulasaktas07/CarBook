using CarBook.Dto.BrandDtos;

namespace CarBook.Aplication.Interfaces.Services;

public interface IBrandService
{
	Task<bool> CreateBrandAsync(CreateBrandRequest createBrandRequest);
	Task<bool> UpdateBrandAsync(UpdateBrandRequest updateBrandRequest);

}
