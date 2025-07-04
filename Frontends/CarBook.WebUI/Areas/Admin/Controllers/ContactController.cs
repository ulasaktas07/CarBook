using CarBook.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class ContactController(IContactApiClient contactApiClient) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var contacts = await contactApiClient.GetContactsAsync();
			return View(contacts);
		}
	}
}
