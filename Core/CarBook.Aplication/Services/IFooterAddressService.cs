using CarBook.Dto.FooterAddressDtos;

namespace CarBook.Aplication.Services
{
	public interface IFooterAddressService
	{
		Task<CreateFooterAddressResult> CreateFooterAddressAsync(CreateFooterAddressRequest createFooterAddressRequest);

		Task<UpdateFooterAddressRequest> UpdateFooterAddressAsync(UpdateFooterAddressRequest updateFooterAddressRequest);
	}
}
