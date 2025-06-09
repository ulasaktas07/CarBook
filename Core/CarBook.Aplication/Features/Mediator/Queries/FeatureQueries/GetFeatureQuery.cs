using CarBook.Aplication.Features.Mediator.Results.FeatureResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.FeatureQueries
{
	public class GetFeatureQuery:IRequest<ServiceResult<List<GetFeatureQueryResult>>>
	{
	}
}
