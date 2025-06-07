using CarBook.Aplication.Features.CQRS.Commands.BannerCommands;
using CarBook.Aplication.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Aplication.Features.CQRS.Queries.BannerQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class BannersController(GetBannerQueryHandler getBannerQueryHandler,GetBannerByIdQueryHandler getBannerByIdQueryHandler,
		CreateBannerCommandHandler createBannerCommandHandler, UpdateBannerCommandHandler updateBannerCommandHandler,
		RemoveBannerCommandHandler removeBannerCommandHandler) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll() => CreateActionResult(await getBannerQueryHandler.Handle());
		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) => CreateActionResult(await getBannerByIdQueryHandler.Handle(new GetBannerByIdQuery(id)));
		[HttpPost]
		public async Task<IActionResult> Create(CreateBannerCommand command) => CreateActionResult(await createBannerCommandHandler.Handle(command));
		[HttpPut]
		public async Task<IActionResult> Update(UpdateBannerCommand command) => CreateActionResult(await updateBannerCommandHandler.Handle(command));
		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) => CreateActionResult(await removeBannerCommandHandler.Handle(new RemoveBannerCommand(id)));

	}
}
