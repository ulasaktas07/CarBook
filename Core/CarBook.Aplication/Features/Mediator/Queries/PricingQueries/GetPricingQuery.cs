using CarBook.Aplication.Features.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.PricingQueries;
public record GetPricingQuery:IRequest<ServiceResult<List<GetPricingQueryResult>>>;