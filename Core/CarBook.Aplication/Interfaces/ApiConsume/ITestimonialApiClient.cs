using CarBook.Dto.TestimonialDtos;
namespace CarBook.Aplication.Interfaces
{
	public interface ITestimonialApiClient
	{
		Task<List<TestimonialDto>> GetTestimonialsAsync();
		Task<CreateTestimonialResult> SendCreateTestimonialAsync(CreateTestimonialRequest createTestimonialRequest);

		Task<UpdateTestimonialRequest> GetTestimonialForUpdateAsync(int id);

		Task<UpdateTestimonialRequest> SendUpdateTestimonialAsync(UpdateTestimonialRequest updateTestimonialRequest);

		Task<bool> DeleteTestimonialAsync(int id);
	}
}
