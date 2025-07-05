using CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using CarBook.Aplication.Features.CQRS.Handlers.AboutHadlers;
using CarBook.Aplication.Features.CQRS.Handlers.CarHandlers;
using CarBook.Aplication.Features.CQRS.Queries.AboutQueries;
using CarBook.Aplication.Features.CQRS.Queries.CarQueries;
using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{

	public class CarsController(GetCarQueryHandler getCarQueryHandler, GetCarByIdQueryHandler getCarByIdQueryHandler, CreateCarCommandHandler createCarCommandHandler,
		UpdateCarCommandHandler updateCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler
		, GetCarWithBrandQueryHandler getCarWithBrandQueryHandler, GetLas5CarsWithBrandQueryHandler getLas5CarsWithBrandQueryHandler) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll() => CreateActionResult(await getCarQueryHandler.Handle());

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) => CreateActionResult(await getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateCarCommand command) => CreateActionResult(await createCarCommandHandler.Handle(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateCarCommand command) => CreateActionResult(await updateCarCommandHandler.Handle(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) => CreateActionResult(await removeCarCommandHandler.Handle(new RemoveCarCommand(id)));

		[HttpGet("GetCarsWithBrands")]
		public IActionResult GetCarsWithBrands() => CreateActionResult(getCarWithBrandQueryHandler.Handle());

		[HttpGet("GetLast5CarsWithBrands")]
		public IActionResult GetLast5CarsWithBrands() => CreateActionResult(getLas5CarsWithBrandQueryHandler.Handle());


	} 
}