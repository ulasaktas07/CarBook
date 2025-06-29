using CarBook.Dto.BrandDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface IBrandApiClient
	{
		Task<List<BrandDto>> GetBrandsAsync();
	}
}
