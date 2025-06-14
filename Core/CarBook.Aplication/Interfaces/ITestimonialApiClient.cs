using CarBook.Dto.TestimonialDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface ITestimonialApiClient
	{
		Task<List<TestimonialDto>> GetTestimonialsAsync();
	}
}
