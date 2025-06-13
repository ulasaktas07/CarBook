using CarBook.Aplication.Features.Mediator.Commands.TestimonialCommands;
using CarBook.Aplication.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class TestimonialsController(IMediator mediator) : CustomBaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll() => CreateActionResult(await mediator.Send(new GetTestimonialQuery()));

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id)=> 
			CreateActionResult(await mediator.Send(new GetTestimonialByIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateTestimonialCommand command) => 
			CreateActionResult(await mediator.Send(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateTestimonialCommand command) => 
			CreateActionResult(await mediator.Send(command));

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Remove(int id) => 
			CreateActionResult(await mediator.Send(new RemoveTestimonialCommand(id)));
	}
}
