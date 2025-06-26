using CarBook.Aplication.Features.Mediator.Results.FeatureResults;
using MediatR;
namespace CarBook.Aplication.Features.Mediator.Queries.FeatureQueries
{
	public record GetFeatureByIdQuery : IRequest<ServiceResult<GetFeatureByIdQueryResult>>
	{
		public int Id { get; }

		public GetFeatureByIdQuery(int id)
		{
			Id = id;
		}
	}
}
