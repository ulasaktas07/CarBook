using CarBook.Aplication.Features.Mediator.Results.CarPricingResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.CarPricingQueries;

public record GetCarPricingWithTimePeriodQuery:IRequest<ServiceResult<List<GetCarPricingWithTimePeriodQueryResult>>>;
