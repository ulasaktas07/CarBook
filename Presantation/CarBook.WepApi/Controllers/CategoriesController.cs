using CarBook.Aplication.Features.CQRS.Commands.CategoryCommands;
using CarBook.Aplication.Features.CQRS.Handlers.CategoryHandlers;
using CarBook.Aplication.Features.CQRS.Queries.CategoryQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class CategoriesController(GetCategoryQueryHandler getCategoryQueryHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler,
		CreateCategoryCommandHandler createCategoryCommandHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler,
		RemoveCategoryCommandHandler removeCategoryCommandHandler) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll() => CreateActionResult(await getCategoryQueryHandler.Handle());

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) => CreateActionResult(await getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id)));
		
		[HttpPost]
		public async Task<IActionResult> Create(CreateCategoryCommand command) => CreateActionResult(await createCategoryCommandHandler.Handle(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateCategoryCommand command) => CreateActionResult(await updateCategoryCommandHandler.Handle(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) => CreateActionResult(await removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id)));

	}
}
