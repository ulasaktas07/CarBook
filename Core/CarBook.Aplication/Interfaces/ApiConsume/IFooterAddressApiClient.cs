using CarBook.Dto.FooterAddressDtos;
namespace CarBook.Aplication.Interfaces
{
	public interface IFooterAddressApiClient
	{
		Task<List<FooterAddressDto>> GetFooterAddressesAsync();
		Task<CreateFooterAddressResult> SendCreateFooterAddressAsync(CreateFooterAddressRequest createFooterAddressRequest);

		Task<UpdateFooterAddressRequest> GetFooterAddressForUpdateAsync(int id);

		Task<UpdateFooterAddressRequest> SendUpdateFooterAddressAsync(UpdateFooterAddressRequest updateFooterAddressRequest);

		Task<bool> DeleteFooterAddressAsync(int id);
	}
}
