using CarBook.Aplication.Features.Mediator.Queries.CarDescriptionQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{

	public class CarDescriptionsController(IMediator mediator) : CustomBaseController
	{
		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetCarDescriptionByCarIdAsync(int id)
			=> CreateActionResult(await mediator.Send(new GetCarDescriptionQuery(id)));


	}
}