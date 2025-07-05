using CarBook.Dto.TestimonialDtos;

namespace CarBook.Aplication.Services
{
	public interface ITestimonialService
	{
		Task<CreateTestimonialResult> CreateTestimonialAsync(CreateTestimonialRequest createTestimonialRequest);

		Task<UpdateTestimonialRequest> UpdateTestimonialAsync(UpdateTestimonialRequest updateTestimonialRequest);
	}
}
