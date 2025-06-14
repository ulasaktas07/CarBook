using CarBook.Dto.FooterAddressDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface IFooterAddressApiClient
	{
		Task<List<FooterAddressDto>> GetFooterAddressesAsync();
	}
}
