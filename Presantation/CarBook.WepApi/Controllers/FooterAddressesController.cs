using CarBook.Aplication.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Aplication.Features.Mediator.Queries.FooterAddressQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class FooterAddressesController(IMediator mediator) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll() =>CreateActionResult(await mediator.Send(new GetFooterAddressQuery()));

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) => CreateActionResult(await mediator.Send(new GetFooterAddressByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateFooterAddressCommand command) => CreateActionResult(await mediator.Send(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateFooterAddressCommand command) => CreateActionResult(await mediator.Send(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) =>CreateActionResult(await mediator.Send(new RemoveFooterAddressCommand(id)));
	}
}
