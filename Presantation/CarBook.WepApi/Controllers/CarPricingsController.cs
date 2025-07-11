using CarBook.Aplication.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class CarPricingsController(IMediator mediator) : CustomBaseController
	{
		[HttpGet("GetCarPricingWithCars")]
		public async Task<IActionResult> GetCarPricingWithCars()
			=> CreateActionResult(await mediator.Send(new GetCarPricingWithCarQuery()));

		[HttpGet("GetCarPricingWithTimePeriod")]
		public async Task<IActionResult> GetCarPricingWithTimePeriod()=>
			CreateActionResult(await mediator.Send(new GetCarPricingWithTimePeriodQuery()));
	}
}
