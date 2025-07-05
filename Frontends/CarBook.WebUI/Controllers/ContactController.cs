using CarBook.Aplication.Services;
using CarBook.Dto.ContactDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class ContactController(IContactService contactService) : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			ViewData["a"] = "İLETİŞİM";
			ViewBag.b= "İLETİŞİM";

			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(CreateContactRequest request)
		{
			ViewData["a"] = "İLETİŞİM";

			if (!ModelState.IsValid)
				return View(request);

			var result = await contactService.CreateContactAsync(request);

			if (result)
				return RedirectToAction("Index", "Default");

			ModelState.AddModelError("", "Kayıt başarısız.");
			return View(request);
		}
	}
}
