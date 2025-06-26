using CarBook.Aplication.Features.Mediator.Commands.LocationCommands;
using CarBook.Aplication.Features.Mediator.Queries.LocationQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class LocationsController(IMediator mediator) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll()=>CreateActionResult(await mediator.Send(new GetLocationQuery()));

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) => CreateActionResult(await mediator.Send(new GetLocationByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateLocationCommand command) => CreateActionResult(await mediator.Send(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateLocationCommand command) => CreateActionResult(await mediator.Send(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) => CreateActionResult(await mediator.Send(new RemoveLocationCommand(id)));
	}
}
