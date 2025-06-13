using CarBook.Aplication.Features.Mediator.Queries.TestimonialQueries;
using CarBook.Aplication.Features.Mediator.Results.TestimonialResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.TestimonialHandlers
{
	public class GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
		: IRequestHandler<GetTestimonialByIdQuery, ServiceResult<GetTestimonialByIdQueryResult>>
	{
		public async Task<ServiceResult<GetTestimonialByIdQueryResult>> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
		{
			var testimonial = await repository.GetByIdAsync(request.Id);

			if (testimonial == null)
			{
				return ServiceResult<GetTestimonialByIdQueryResult>.Fail("Testimonial bulunamadı",HttpStatusCode.NotFound);
			}

			var result = new GetTestimonialByIdQueryResult(testimonial.Id, testimonial.Name, testimonial.Title, testimonial.Comment,
				testimonial.ImageUrl);

			return ServiceResult<GetTestimonialByIdQueryResult>.Success(result);


		}
	}
}
