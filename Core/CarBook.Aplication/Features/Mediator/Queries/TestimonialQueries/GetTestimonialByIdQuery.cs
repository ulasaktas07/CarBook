using CarBook.Aplication.Features.Mediator.Results.TestimonialResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.TestimonialQueries
{
	public record GetTestimonialByIdQuery:IRequest<ServiceResult<GetTestimonialByIdQueryResult>>
	{
		public int Id { get; init; }
		public GetTestimonialByIdQuery(int id)
		{
			Id = id;
		}
	}
}
