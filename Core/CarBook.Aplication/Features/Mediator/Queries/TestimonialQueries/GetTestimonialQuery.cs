using CarBook.Aplication.Features.Mediator.Results.TestimonialResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.TestimonialQueries;
	public record GetTestimonialQuery:IRequest<ServiceResult<List<GetTestimonialQueryResult>>>;