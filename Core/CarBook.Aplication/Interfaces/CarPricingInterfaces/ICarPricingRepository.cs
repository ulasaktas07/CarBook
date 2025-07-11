using CarBook.Aplication.ViewModels;
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Interfaces.CarPricingInterfaces
{
	public interface ICarPricingRepository
	{
		Task<List<CarPricing>> GetCarPricingWithCars();
		Task<List<CarPricingViewModel>> GetCarPricingWithTimePeriod();

	}
}
