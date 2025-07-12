using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
