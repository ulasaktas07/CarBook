using CarBook.Dto.ServiceDtos;

namespace CarBook.Aplication.Interfaces.Services
{
	public interface IServiceService
	{
		Task<CreateServiceResult> CreateServiceAsync(CreateServiceRequest createServiceRequest);

		Task<UpdateServiceRequest> UpdateServiceAsync(UpdateServiceRequest updateServiceRequest);
	}
}
