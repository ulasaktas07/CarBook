using AutoMapper;
using CarBook.Aplication.Features.Mediator.Commands.ServiceCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Services;
using CarBook.Dto.ServiceDtos;

namespace CarBook.Persistence.Services
{
	public class ServiceService(IServiceApiClient serviceApiClient, IMapper mapper) : IServiceService
	{
		public async Task<CreateServiceResult> CreateServiceAsync(CreateServiceRequest createServiceRequest)
		{
			var command = mapper.Map<CreateServiceCommand>(createServiceRequest);
			return await serviceApiClient.SendCreateServiceAsync(createServiceRequest);
		}

		public async Task<UpdateServiceRequest> UpdateServiceAsync(UpdateServiceRequest updateServiceRequest)
		{
			var command = mapper.Map<UpdateServiceCommand>(updateServiceRequest);
			return await serviceApiClient.SendUpdateServiceAsync(updateServiceRequest);
		}
	}
}
