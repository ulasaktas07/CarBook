using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.FooterAddressDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.FooterAddressComponents
{
	public class _FooterAddressComponentPartial(IFooterAddressApiClient footerAddressApiClient) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var footerAddresses = await footerAddressApiClient.GetFooterAddressesAsync();

			return View(footerAddresses);

		}
	}
}
