using CarBook.Aplication.Features.Mediator.Commands.ServiceCommands;
using CarBook.Aplication.Features.Mediator.Queries.ServiceQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace CarBook.WepApi.Controllers
{
	public class ServicesController(IMediator mediator) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll() => CreateActionResult(await mediator.Send(new GetServiceQuery()));

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) => CreateActionResult(await mediator.Send(new GetServiceByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateServiceCommand command)=> CreateActionResult(await mediator.Send(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateServiceCommand command) => CreateActionResult(await mediator.Send(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) => CreateActionResult(await mediator.Send(new RemoveServiceCommand(id)));
	}
}
