using BlogBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using BrandBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using LocationBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WepApi.Controllers
{

	public class StatisticsController(IMediator mediator) : CustomBaseController
	{
		[HttpGet("GetCarCount")]
		public async Task<IActionResult> GetCarCount() => CreateActionResult(await mediator.Send(new GetCarCountQuery()));

		[HttpGet("GetLocationCount")]
		public async Task<IActionResult> GetLocationCount() => CreateActionResult(await mediator.Send(new GetLocationCountQuery()));

		[HttpGet("GetBrandCount")]
		public async Task<IActionResult> GetBrandCount() => CreateActionResult(await mediator.Send(new GetBrandCountQuery()));

		[HttpGet("GetBlogCount")]
		public async Task<IActionResult> GetBlogCount() => CreateActionResult(await mediator.Send(new GetBlogCountQuery()));

		[HttpGet("GetAvrgRentPriceForDaily")]
		public async Task<IActionResult> GetAvrgRentPriceForDaily() =>
			CreateActionResult(await mediator.Send(new GetAvrgRentPriceForDailyQuery()));

		[HttpGet("GetAvrgRentPriceForMonthly")]
		public async Task<IActionResult> GetAvrgRentPriceForMonthly() =>
			CreateActionResult(await mediator.Send(new GetAvrgRentPriceForMonthlyQuery()));

		[HttpGet("GetAvrgRentPriceForWeekly")]
		public async Task<IActionResult> GetAvrgRentPriceForWeekly() => 
			CreateActionResult(await mediator.Send(new GetAvrgRentPriceForWeeklyQuery()));

		[HttpGet("GetCarCountByTransmissionIsAuto")]
		public async Task<IActionResult> GetCarCountByTransmissionIsAuto() => 
			CreateActionResult(await mediator.Send(new GetCarCountByTransmissionIsAutoQuery()));

		[HttpGet("GetBrandNameByMaxCar")]
		public async Task<IActionResult> GetBrandNameByMaxCar() => 
			CreateActionResult(await mediator.Send(new GetBrandNameByMaxCarQuery()));

		[HttpGet(" GetBlogTitleByMaxBlogComment")]
		public async Task<IActionResult> GetBlogTitleByMaxBlogComment() => 
			CreateActionResult(await mediator.Send(new GetBlogTitleByMaxBlogCommentQuery()));

		[HttpGet("GetCarCountByKmSmallerThan1000")]
		public async Task<IActionResult> GetCarCountByKmSmallerThan1000() => 
			CreateActionResult(await mediator.Send(new GetCarCountByKmSmallerThan1000Query()));

		[HttpGet("GetCarCountByFuelGasolineOrDiesel")]
		public async Task<IActionResult> GetCarCountByFuelGasolineOrDiesel() => 
			CreateActionResult(await mediator.Send(new GetCarCountByFuelGasolineOrDieselQuery()));

		[HttpGet("GetCarCountByFuelElectric")]
		public async Task<IActionResult> GetCarCountByFuelElectric() => 
			CreateActionResult(await mediator.Send(new GetCarCountByFuelElectricQuery()));

		[HttpGet("GetCarBrandAndModelByRentPriceDailyMax")]
		public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMax() => 
			CreateActionResult(await mediator.Send(new GetCarBrandAndModelByRentPriceDailyMaxQuery()));

		[HttpGet("GetCarBrandAndModelByRentPriceDailyMin")]
		public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMin() => 
			CreateActionResult(await mediator.Send(new GetCarBrandAndModelByRentPriceDailyMinQuery()));


	}
}
