using CarBook.Aplication.Interfaces;
using CarBook.Dto;
using CarBook.Dto.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.TestimonialViewComponents
{
	public class _TestimonialComponentsPartial(ITestimonialApiClient  testimonialApiClient) : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var testimonials = await testimonialApiClient.GetTestimonialsAsync();
			return View(testimonials);
		}
	}
}
