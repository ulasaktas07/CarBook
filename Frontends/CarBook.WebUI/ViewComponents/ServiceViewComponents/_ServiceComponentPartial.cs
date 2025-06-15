using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.ServiceViewComponents
{
	public class _ServiceComponentPartial(IServiceApiClient serviceApiClient) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var services = await serviceApiClient.GetServicesAsync();

			return View(services);
		}
	}
}
