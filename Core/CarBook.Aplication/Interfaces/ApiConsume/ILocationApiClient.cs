using CarBook.Dto.LocationDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface ILocationApiClient
	{
		Task<List<LocationDto>> GetLocationsAsync();

		Task<CreateLocationResult> SendCreateLocationAsync(CreateLocationRequest createLocationRequest);

		Task<UpdateLocationRequest> GetLocationForUpdateAsync(int id);

		Task<UpdateLocationRequest> SendUpdateLocationAsync(UpdateLocationRequest updateLocationRequest);

		Task<bool> DeleteLocationAsync(int id);
	}
}
