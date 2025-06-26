using CarBook.Aplication.Features.Mediator.Commands.TagCloudCommands;
using CarBook.Aplication.Features.Mediator.Queries.TagCloudQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class TagCloudsController(IMediator mediator) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll()=> CreateActionResult(await mediator.Send(new GetTagCloudQuery()));

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)=> 
			CreateActionResult(await mediator.Send(new GetTagCloudByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateTagCloudCommand command) => 
			CreateActionResult(await mediator.Send(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateTagCloudCommand command) => 
			CreateActionResult(await mediator.Send(command));

		[HttpDelete("{id}")]
		public async Task<IActionResult> Remove(int id) => 
			CreateActionResult(await mediator.Send(new RemoveTagCloudCommand(id)));

		[HttpGet("GetTagCloudBlogId")]
		public async Task<IActionResult> GetTagCloudBlogId(int blogId) => 
			CreateActionResult(await mediator.Send(new GetTagCloudByBlogIdQuery(blogId)));


	}
}
