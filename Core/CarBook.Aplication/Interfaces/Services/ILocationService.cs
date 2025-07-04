using CarBook.Dto.LocationDtos;

namespace CarBook.Aplication.Interfaces.Services
{
	public interface ILocationService
	{
		Task<CreateLocationResult> CreateLocationAsync(CreateLocationRequest createLocationRequest);

		Task<UpdateLocationRequest> UpdateLocationAsync(UpdateLocationRequest updateLocationRequest);
	}
}
