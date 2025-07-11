using CarBook.Aplication.Features.Mediator.Commands.ReservationCommands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class ReservationsController(IMediator mediator) : CustomBaseController
	{
		[HttpPost]
		public async Task<IActionResult> CreateReservation(CreateReservationCommand command)
			=> CreateActionResult(await mediator.Send(command));
	}
}
