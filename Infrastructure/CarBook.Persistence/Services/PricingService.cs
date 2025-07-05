using AutoMapper;
using CarBook.Aplication.Features.Mediator.Commands.PricingCommands;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.PricingDtos;

namespace CarBook.Persistence.Services
{
	public class PricingService(IPricingApiClient pricingApiClient, IMapper mapper) : IPricingService
	{
		public async Task<CreatePricingResult> CreatePricingAsync(CreatePricingRequest createPricingRequest)
		{
			var command = mapper.Map<CreatePricingCommand>(createPricingRequest);
			return await pricingApiClient.SendCreatePricingAsync(createPricingRequest);
		}

		public async Task<UpdatePricingRequest> UpdatePricingAsync(UpdatePricingRequest updatePricingRequest)
		{
			var command = mapper.Map<UpdatePricingCommand>(updatePricingRequest);
			return await pricingApiClient.SendUpdatePricingAsync(updatePricingRequest);
		}
	}
}
