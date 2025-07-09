using CarBook.Aplication.Features.Mediator.Queries.RentACarQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace CarBook.WepApi.Controllers
{
	public class RentACarsController(IMediator mediator) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetRentACarListByLocation(int LocationID, bool Available)
			=>CreateActionResult(await mediator.Send(new GetRentACarQuery(LocationID, Available)));

	}
}
