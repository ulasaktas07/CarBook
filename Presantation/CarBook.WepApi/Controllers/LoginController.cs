using CarBook.Aplication.Features.Mediator.Queries.AppUserQueries;
using CarBook.Aplication.Tools;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CarBook.WepApi.Controllers
{
	public class LoginController(IMediator mediator) : CustomBaseController
	{
		[HttpPost]
		public async Task<IActionResult> Index(GetCheckAppUserQuery getCheckAppUserQuery)
		{
			var result = await mediator.Send(getCheckAppUserQuery);

			if (result.IsSuccess && result.Data is not null)
			{
				var token = JwtTokenGenerator.GenerateToken(result.Data); // ✅ DTO'yu veriyoruz
				return Created("", token);
			}
			else
			{
				if (result.ErrorMessage is null || result.ErrorMessage.Count == 0)
					result.ErrorMessage = ["Kullanıcı adı veya şifre yanlış."]; // Hata mesajı yoksa varsayılan mesaj ekle
				result.Status = HttpStatusCode.Unauthorized; // ❌ durum kodunu Unauthorized olarak ayarla

			}

			return CreateActionResult(result); // ❌ durumlar için hata mesajı
		}
	}
}