using CarBook.Aplication.Features.Mediator.Results.FeatureResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.FeatureQueries
{
	public record GetFeatureQuery:IRequest<ServiceResult<List<GetFeatureQueryResult>>>
	{
	}
}
