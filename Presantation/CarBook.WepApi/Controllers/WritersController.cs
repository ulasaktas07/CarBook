using CarBook.Aplication.Features.Mediator.Commands.WriterCommands;
using CarBook.Aplication.Features.Mediator.Queries.WriterQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class WritersController(IMediator mediator) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll() => CreateActionResult(await mediator.Send(new GetWriterQuery()));

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) 
			=> CreateActionResult(await mediator.Send(new GetWriterByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateWriterCommand command) 
			=> CreateActionResult(await mediator.Send(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateWriterCommand command) 
			=> CreateActionResult(await mediator.Send(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) 
			=> CreateActionResult(await mediator.Send(new RemoveWriterCommand(id)));
	}
}
