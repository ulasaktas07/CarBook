using AutoMapper;
using CarBook.Aplication.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.FooterAddressDtos;

namespace CarBook.Persistence.Services
{
	public class FooterAddressService(IFooterAddressApiClient footerAddressApiClient,IMapper mapper):IFooterAddressService
	{
		public async Task<CreateFooterAddressResult> CreateFooterAddressAsync(CreateFooterAddressRequest createFooterAddressRequest)
		{
			var command = mapper.Map<CreateFooterAddressCommand>(createFooterAddressRequest);
			return await footerAddressApiClient.SendCreateFooterAddressAsync(createFooterAddressRequest);
		}

		public async Task<UpdateFooterAddressRequest> UpdateFooterAddressAsync(UpdateFooterAddressRequest updateFooterAddressRequest)
		{
			var command = mapper.Map<UpdateFooterAddressCommand>(updateFooterAddressRequest);
			return await footerAddressApiClient.SendUpdateFooterAddressAsync(updateFooterAddressRequest);
		}
	}
}
