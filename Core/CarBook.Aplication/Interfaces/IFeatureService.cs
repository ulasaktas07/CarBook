
using CarBook.Dto.FeatureDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface IFeatureService
	{
		Task<bool> CreateFeatureAsync(CreateFeatureRequest createFeatureRequest);

		Task<bool> UpdateFeatureAsync(ResultFeatureDto resultFeatureDto);

	}
}
