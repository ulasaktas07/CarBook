using CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
using CarBook.Aplication.Features.Mediator.Queries.FeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{

	public class FeaturesController(IMediator mediator) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll() => CreateActionResult(await mediator.Send(new GetFeatureQuery()));

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) => CreateActionResult(await mediator.Send(new GetFeatureByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateFeatureCommand command) => CreateActionResult(await mediator.Send(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateFeatureCommand command) => CreateActionResult(await mediator.Send(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) =>CreateActionResult(await mediator.Send(new RemoveFeatureCommand(id)));
	}
}
