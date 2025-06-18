using CarBook.Dto.CarPricingDtos;
namespace CarBook.Aplication.Interfaces
{
	public interface ICarPricingClient
	{
		Task<List<CarPricingWithCarDto>> GetCarPricingWithCarsAsync();
	}
}
