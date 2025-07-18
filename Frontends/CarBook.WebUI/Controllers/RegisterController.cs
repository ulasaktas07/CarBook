using CarBook.Aplication.Services;
using CarBook.Dto.RegisterDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class RegisterController(IRegisterService registerService) : Controller
	{
		[HttpGet]
		public IActionResult CreateAppUser()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateAppUser(CreateRegisterRequest request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}
			var result = await registerService.CreateRegisterAsync(request);
				return RedirectToAction("Index", "Login");

		}
	}
}
