using CarBook.Dto.CarPricingDtos;
namespace CarBook.Aplication.Interfaces
{
	public interface ICarPricingApiClient
	{
		Task<List<CarPricingWithCarDto>> GetCarPricingWithCarsAsync();
		Task<List<CarPricingListWithModelDto>> GetCarPricingListWithModelsAsync();
	}
}
