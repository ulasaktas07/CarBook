using AutoMapper;
using CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto.FeatureDtos;

namespace CarBook.Aplication.Services
{
	public class FeatureService(IFeatureApiClient featureApiClient, IMapper mapper) : IFeatureService
	{
		public async Task<bool> CreateFeatureAsync(CreateFeatureRequest createFeatureRequest)
		{
			var command = mapper.Map<CreateFeatureCommand>(createFeatureRequest);
			return await featureApiClient.SendCreateFeatureAsync(createFeatureRequest);
		}

		public async Task<bool> UpdateFeatureAsync(ResultFeatureDto resultFeatureDto)
		{
			var command = mapper.Map<UpdateFeatureCommand>(resultFeatureDto);
			return await featureApiClient.SendUpdateFeatureAsync(resultFeatureDto);
		}
	}
}
