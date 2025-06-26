using CarBook.Aplication.Features.Mediator.Results.PricingResults;
using MediatR;
namespace CarBook.Aplication.Features.Mediator.Queries.PricingQueries
{
	public record GetPricingByIdQuery : IRequest<ServiceResult<GetPricingByIdQueryResult>>
	{
		public int Id { get; init; }
		public GetPricingByIdQuery(int id)
		{
			Id = id;
		}
	}
}
