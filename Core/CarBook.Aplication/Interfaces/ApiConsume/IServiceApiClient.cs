using CarBook.Dto.ServiceDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface IServiceApiClient
	{
		Task<List<ServiceDto>> GetServicesAsync();
	}
}
