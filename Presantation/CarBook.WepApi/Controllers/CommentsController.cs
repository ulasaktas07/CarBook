using CarBook.Aplication.Features.Mediator.Commands.CommentCommands;
using CarBook.Aplication.Features.Mediator.Queries.CommentQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{

	public class CommentsController(IMediator mediator) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll() => CreateActionResult(await mediator.Send(new GetCommentQuery()));

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id) => CreateActionResult(await mediator.Send(new GetCommentByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateCommentCommad command) => CreateActionResult(await mediator.Send(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateCommentCommand command) => CreateActionResult(await mediator.Send(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) => CreateActionResult(await mediator.Send(new RemoveCommentCommand(id)));

		[HttpGet("CommentListByBlog")]
		public async Task<IActionResult> GetCommentsByBlogId(int id) 
			=> CreateActionResult(await mediator.Send(new GetCommentsByBlogIdQuery(id)));

		[HttpGet("CommentCountByBlogId")]
		public async Task<IActionResult> GetCommentCountByBlogId(int id) 
			=> CreateActionResult(await mediator.Send(new GetCommentCountByBlogIdQuery(id)));

	}
}
