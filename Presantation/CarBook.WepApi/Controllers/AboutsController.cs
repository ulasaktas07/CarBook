using CarBook.Aplication.Features.CQRS.Commands.AboutCommands;
using CarBook.Aplication.Features.CQRS.Handlers.AboutHadlers;
using CarBook.Aplication.Features.CQRS.Queries.AboutQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class AboutsController(CreateAboutCommandHandler createAboutCommandHandler, GetAboutByIdQueryHandler getAboutByIdQueryHandler,
		GetAboutQueryHandler getAboutQueryHandler,UpdateAboutCommandHandler updateAboutCommandHandler,
		RemoveAboutCommandHandler removeAboutCommandHandler) : CustomBaseController
	{

		[HttpGet]
		public async Task<IActionResult> GetAll() => CreateActionResult(await getAboutQueryHandler.Handle());
	
		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) =>CreateActionResult(await getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id)));
		
		[HttpPost]
		public async Task<IActionResult> Create(CreateAboutCommand command)=> CreateActionResult(await createAboutCommandHandler.Handle(command));
	
		[HttpPut]
		public async Task<IActionResult> Update(UpdateAboutCommand command)=> CreateActionResult(await updateAboutCommandHandler.Handle(command));
	
		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) => CreateActionResult(await removeAboutCommandHandler.Handle(new RemoveAboutCommand(id)));
	}
}
