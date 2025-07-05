using AutoMapper;
using CarBook.Aplication.Features.Mediator.Commands.TestimonialCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Services;
using CarBook.Dto.TestimonialDtos;

namespace CarBook.Persistence.Services
{
	public class TestimonialService(ITestimonialApiClient TestimonialApiClient, IMapper mapper) : ITestimonialService
	{
		public async Task<CreateTestimonialResult> CreateTestimonialAsync(CreateTestimonialRequest createTestimonialRequest)
		{
			var command = mapper.Map<CreateTestimonialCommand>(createTestimonialRequest);
			return await TestimonialApiClient.SendCreateTestimonialAsync(createTestimonialRequest);
		}

		public async Task<UpdateTestimonialRequest> UpdateTestimonialAsync(UpdateTestimonialRequest updateTestimonialRequest)
		{
			var command = mapper.Map<UpdateTestimonialCommand>(updateTestimonialRequest);
			return await TestimonialApiClient.SendUpdateTestimonialAsync(updateTestimonialRequest);
		}
	}
}
