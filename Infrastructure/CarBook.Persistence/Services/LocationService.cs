using AutoMapper;
using CarBook.Aplication.Features.Mediator.Commands.LocationCommands;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.LocationDtos;

namespace CarBook.Persistence.Services
{

	public class LocationService(ILocationApiClient locationApiClient, IMapper mapper) : ILocationService
	{
		public async Task<CreateLocationResult> CreateLocationAsync(CreateLocationRequest createLocationRequest)
		{
			var command = mapper.Map<CreateLocationCommand>(createLocationRequest);
			return await locationApiClient.SendCreateLocationAsync(createLocationRequest);
		}

		public async Task<UpdateLocationRequest> UpdateLocationAsync(UpdateLocationRequest updateLocationRequest)
		{
			var command = mapper.Map<UpdateLocationCommand>(updateLocationRequest);
			return await locationApiClient.SendUpdateLocationAsync(updateLocationRequest);
		}
	}
}
