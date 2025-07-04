using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class TestimonialController(ITestimonialApiClient testimonialApiClient, ITestimonialService testimonialService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var Testimonials = await testimonialApiClient.GetTestimonialsAsync();
			return View(Testimonials);
		}
		[HttpGet]
		public IActionResult CreateTestimonial()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateTestimonial(CreateTestimonialRequest createTestimonialRequest)
		{
			if (!ModelState.IsValid)
			{
				return View(createTestimonialRequest);
			}
			var result = await testimonialService.CreateTestimonialAsync(createTestimonialRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
		[HttpGet]
		public async Task<IActionResult> UpdateTestimonial(int id)
		{
			var Testimonial = await testimonialApiClient.GetTestimonialForUpdateAsync(id);
			if (Testimonial == null)
			{
				return NotFound();
			}
			return View(Testimonial);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialRequest updateTestimonialRequest)
		{
			var result = await testimonialService.UpdateTestimonialAsync(updateTestimonialRequest);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}

		public async Task<IActionResult> RemoveTestimonial(int id)
		{
			var result = await testimonialApiClient.DeleteTestimonialAsync(id);

			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
	}
}
