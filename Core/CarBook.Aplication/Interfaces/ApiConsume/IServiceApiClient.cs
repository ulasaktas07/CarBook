using CarBook.Dto.ServiceDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface IServiceApiClient
	{
		Task<List<ServiceDto>> GetServicesAsync();
		Task<CreateServiceResult> SendCreateServiceAsync(CreateServiceRequest createServiceRequest);

		Task<UpdateServiceRequest> GetServiceForUpdateAsync(int id);

		Task<UpdateServiceRequest> SendUpdateServiceAsync(UpdateServiceRequest updateServiceRequest);

		Task<bool> DeleteServiceAsync(int id);
	}
}
