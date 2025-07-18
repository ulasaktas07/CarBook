using CarBook.Aplication.Features.Mediator.Commands.AppUserCommands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class RegistersController(IMediator mediator) : CustomBaseController
	{
		[HttpPost]
 		public async Task<IActionResult> Create(CreateAppUserCommand createAppUserCommand)
            => CreateActionResult(await mediator.Send(createAppUserCommand));


	}
}
