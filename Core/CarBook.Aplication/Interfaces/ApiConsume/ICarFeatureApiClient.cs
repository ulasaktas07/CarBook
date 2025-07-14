using CarBook.Dto.CarFeatureDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface ICarFeatureApiClient
	{
		Task<List<CarFeatureByCarIdDto>> GetCarFeaturesByCarIdAsync(int id);

		Task<CarFeatureByCarIdDto> ChangeCarFeatureAvailableToFalseAsync(CarFeatureByCarIdDto carFeatureByCarIdDto);

		Task<CarFeatureByCarIdDto> ChangeCarFeatureAvailableToTrueAsync(CarFeatureByCarIdDto carFeatureByCarIdDto);
	}
}
