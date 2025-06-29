using CarBook.Dto.BrandDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface IBrandApiClient
	{
		Task<List<BrandDto>> GetBrandsAsync();
		Task<bool> SendCreateBrandAsync(CreateBrandRequest createBrandRequest);

		Task<bool> SendDeleteBrandAsync(int id);

		Task<bool> SendUpdateBrandAsync(UpdateBrandRequest updateBrandRequest);

		Task<UpdateBrandRequest> GetBrandByIdAsync(int id);
	}
}
