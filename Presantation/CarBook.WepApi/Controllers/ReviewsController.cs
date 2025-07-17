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


	}
}
