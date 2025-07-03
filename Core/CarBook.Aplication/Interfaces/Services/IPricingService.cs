using CarBook.Dto.PricingDtos;

namespace CarBook.Aplication.Interfaces.Services
{
	public interface IPricingService
	{
		Task<CreatePricingResult> CreatePricingAsync(CreatePricingRequest createPricingRequest);

		Task<UpdatePricingRequest> UpdatePricingAsync(UpdatePricingRequest updatePricingRequest);
	}
}
