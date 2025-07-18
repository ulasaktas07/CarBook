using CarBook.Aplication.Features.Mediator.Commands.ReviewCommands;
using CarBook.Aplication.Features.Mediator.Queries.ReviewQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class ReviewsController(IMediator mediator) : CustomBaseController
	{
		[HttpGet("GetReviewsByCarId/{id}")]
		public async Task<IActionResult> GetReviewsByCarIdAsync(int id)
			=> CreateActionResult(await mediator.Send(new GetReviewByCarIdQuery(id)));

		[HttpPost]
		public async Task<IActionResult> Create(CreateReviewCommand command)
			=> CreateActionResult(await mediator.Send(command));

		[HttpPut]
		public async Task<IActionResult> Update(UpdateReviewCommand command)
		=> CreateActionResult(await mediator.Send(command));

		[HttpDelete("{id}")]
		public async Task<IActionResult> Remove(int id)
		=> CreateActionResult(await mediator.Send(new RemoveReviewCommand(id)));

	


	}
}
