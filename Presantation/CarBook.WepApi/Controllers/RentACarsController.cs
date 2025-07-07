using CarBook.Aplication.Features.Mediator.Queries.RentACarQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace CarBook.WepApi.Controllers
{
	public class RentACarsController(IMediator mediator) : CustomBaseController
	{
		[HttpPost]
		public async Task<IActionResult> GetRentACarListByLocation(GetRentACarQuery getRentACarQuery)
			=> CreateActionResult(await mediator.Send(getRentACarQuery));
	}
}
