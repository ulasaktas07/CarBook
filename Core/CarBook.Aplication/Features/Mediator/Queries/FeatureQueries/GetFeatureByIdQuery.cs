using CarBook.Aplication.Features.Mediator.Results.FeatureResults;
using MediatR;
namespace CarBook.Aplication.Features.Mediator.Queries.FeatureQueries
{
	public class GetFeatureByIdQuery:IRequest<ServiceResult<GetFeatureByIdQueryResult>>
	{
		public int Id { get; set; }
		public GetFeatureByIdQuery(int id)
		{
			Id = id;
		}
	}
}
