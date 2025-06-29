using CarBook.Dto.AboutDtos;
using CarBook.Dto.FeatureDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface IFeatureApiClient
	{
		Task<List<FeatureDto>> GetFeaturesAsync();
		Task<bool> SendCreateFeatureAsync(CreateFeatureRequest createFeatureRequest);

		Task<bool> SendUpdateFeatureAsync(UpdateFeatureRequest resultFeatureDto);

		Task<bool> SendDeleteFeatureAsync(int id);

		Task<UpdateFeatureRequest> GetFeatureByIdAsync(int id);



	}
}
