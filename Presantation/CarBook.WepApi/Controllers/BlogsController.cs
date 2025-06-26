using CarBook.Aplication.Features.Mediator.Commands.BlogCommands;
using CarBook.Aplication.Features.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class BlogsController(IMediator mediator) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll()=>CreateActionResult(await mediator.Send(new GetBlogQuery()));	

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id)=> CreateActionResult(await mediator.Send(new GetBlogByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateBlogCommand command)=> CreateActionResult(await mediator.Send(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateBlogCommand command)=> CreateActionResult(await mediator.Send(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id)=> CreateActionResult(await mediator.Send(new RemoveBlogCommand(id)));


		[HttpGet("GetLast3BlogsWithWriters")]
		public async Task<IActionResult> GetLast3BlogsWithWriters() 
			=> CreateActionResult(await mediator.Send(new GetLast3BlogsWithWritersQuery()));

		[HttpGet("GetAllBlogsWithWriters")]
		public async Task<IActionResult> GetAllBlogsWithWriters() 
			=> CreateActionResult(await mediator.Send(new GetAllBlogsWithWritterQuery()));


		[HttpGet("GetBlogByWriterId")]
		public async Task<IActionResult> GetBlogByWriterId(int id) 
			=> CreateActionResult(await mediator.Send(new GetBlogByWriterIdQuery(id)));
	}
}
