using CarBook.Aplication.Features.Mediator.Queries.TestimonialQueries;
using CarBook.Aplication.Features.Mediator.Results.TestimonialResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace CarBook.Aplication.Features.Mediator.Handlers.TestimonialHandlers
{
	public class GetTestimonialQueryHandler(IRepository<Testimonial> repository)
		: IRequestHandler<GetTestimonialQuery, ServiceResult<List<GetTestimonialQueryResult>>>
	{
		public async Task<ServiceResult<List<GetTestimonialQueryResult>>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
		{
			var testimonials = await repository.GetAllAsync();

	
			var result = testimonials.Select(t => new GetTestimonialQueryResult(t.Id,t.Name,t.Title,t.Comment,t.ImageUrl)).ToList();

			return ServiceResult<List<GetTestimonialQueryResult>>.Success(result);
		}
	}
}
