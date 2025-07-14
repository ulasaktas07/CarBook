using CarBook.Domain.Entities;

namespace CarBook.Aplication.Interfaces.CarFeatureInterfaces
{
	public interface ICarFeatureRepository
	{
		Task<List<CarFeature>> GetCarFeaturesByCarIdAsync(int carID);

		Task<CarFeature> ChangeCarFeatureAvailableToFalseAsync(int id);

		Task<CarFeature> ChangeCarFeatureAvailableToTrueAsync(int id);

	}
}
