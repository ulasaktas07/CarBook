using CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommands;
using CarBook.Aplication.Features.Mediator.Queries.SocialMediaQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class SocialMediasController(IMediator mediator) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll() => CreateActionResult(await mediator.Send(new GetSocialMediaQuery()));

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id)=> CreateActionResult(await mediator.Send(new GetSocialMediaByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateSocialMediaCommand command)=> CreateActionResult(await mediator.Send(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateSocialMediaCommand command) => CreateActionResult(await mediator.Send(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) => CreateActionResult(await mediator.Send(new RemoveSocialMediaCommand(id)));
	}
}
