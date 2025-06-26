using CarBook.Aplication.Features.CQRS.Commands.BrandCommands;
using CarBook.Aplication.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Aplication.Features.CQRS.Queries.BrandQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class BrandsController(GetBrandQueryHandler getBrandQueryHandler, GetBrandByIdQueryHandler getBrandByIdQueryHandler,
		CreateBrandCommandHandler createBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler,
		RemoveBrandCommandHandler removeBrandCommandHandler) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll()=> CreateActionResult(await getBrandQueryHandler.Handle());

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) => CreateActionResult(await getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateBrandCommand createBrand) => CreateActionResult(await createBrandCommandHandler.Handle(createBrand));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateBrandCommand updateBrand) => CreateActionResult(await updateBrandCommandHandler.Handle(updateBrand));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) => CreateActionResult(await removeBrandCommandHandler.Handle(new RemoveBrandCommand(id)));
	}
}
