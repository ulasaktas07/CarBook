using CarBook.Dto.PricingDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface IPricingApiClient
	{
		Task<List<PricingDto>> GetPricingsAsync();

		Task<CreatePricingResult> SendCreatePricingAsync(CreatePricingRequest createPricingRequest);

		Task<UpdatePricingRequest> GetPricingForUpdateAsync(int id);

		Task<UpdatePricingRequest> SendUpdatePricingAsync(UpdatePricingRequest updatePricingRequest);

		Task<bool> DeletePricingAsync(int id);
	}
}
