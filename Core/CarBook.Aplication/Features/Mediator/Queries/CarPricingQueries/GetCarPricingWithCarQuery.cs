using CarBook.Aplication;
using CarBook.Aplication.Features.Mediator.Results.CarPricingResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.CarPricingQueries
{
	public record GetCarPricingWithCarQuery
		: IRequest<ServiceResult<List<GetCarPricingWithCarQueryResult>>>;
}