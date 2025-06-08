using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Aplication.Features.CQRS.Handlers.ContactHandlers;
using CarBook.Aplication.Features.CQRS.Queries.ContactQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class ContactsController(GetContactQueryHandler getContactQueryHandler, GetContactByIdQueryHandler getContactByIdQueryHandler,
		CreateContactCommandHandler createContactCommandHandler, UpdateContactCommandHandler updateContactCommandHandler,
		RemoveContactCommandHandler removeContactCommandHandler) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll() => CreateActionResult(await getContactQueryHandler.Handle());

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) => CreateActionResult(await getContactByIdQueryHandler.Handle(new GetContactByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateContactCommand command)=> CreateActionResult(await createContactCommandHandler.Handle(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateContactCommand command) => CreateActionResult(await updateContactCommandHandler.Handle(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) => CreateActionResult(await removeContactCommandHandler.Handle(new RemoveContactCommand(id)));
	}
}
