using CarBook.Aplication.Services;
using CarBook.Dto.LoginDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class LoginController(ILoginService loginService) : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(CreateLoginRequest request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}
			var result = await loginService.CreateLoginAsync(request);

				return RedirectToAction("Index", "Default");
		
			
		}
	}
}
