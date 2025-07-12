using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponents
{
	public class _FooterUILayoutComponentPartial(IFooterAddressApiClient footerAddressApiClient) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var footerAddresses = await footerAddressApiClient.GetFooterAddressesAsync();
			return View(footerAddresses);
		}
	}
}
