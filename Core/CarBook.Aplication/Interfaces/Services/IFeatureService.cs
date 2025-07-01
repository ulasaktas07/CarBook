using CarBook.Dto.FeatureDtos;

namespace CarBook.Aplication.Interfaces.Services;

public interface IFeatureService
{
	Task<bool> CreateFeatureAsync(CreateFeatureRequest createFeatureRequest);

	Task<bool> UpdateFeatureAsync(UpdateFeatureRequest resultFeatureDto);

}
