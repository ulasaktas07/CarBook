using CarBook.Aplication.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Aplication.Features.Mediator.Queries.CarFeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{
	public class CarFeaturesController(IMediator mediator) : CustomBaseController
	{
		[HttpGet("GetCarFeaturesByCarId/{id}")]
		public async Task<IActionResult> GetCarFeaturesByCarId(int id)
           	=> CreateActionResult(await mediator.Send(new GetCarFeatureByCarIdQuery(id)));

		[HttpGet("ChangeCarFeatureAvailableToFalse/{id}")]
		public async Task<IActionResult> ChangeCarFeatureAvailableToFalse(int id)
			=> CreateActionResult(await mediator.Send(new UpdateCarFeatureAvailableChangeToFalseCommand(id)));

		[HttpGet("ChangeCarFeatureAvailableToTrue/{id}")]
		public async Task<IActionResult> ChangeCarFeatureAvailableToTrue(int id)
			=> CreateActionResult(await mediator.Send(new UpdateCarFeatureAvailableChangeToTrueCommand(id)));

		[HttpPost("CreateCarFeatureByCar")]
		public async Task<IActionResult> CreateCarFeatureByCar(CreateCarFeatureByCarCommand command)
			=> CreateActionResult(await mediator.Send(command));
	}
}
