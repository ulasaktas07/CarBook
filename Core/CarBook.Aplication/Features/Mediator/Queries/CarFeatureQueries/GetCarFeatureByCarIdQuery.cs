using CarBook.Aplication.Features.Mediator.Results.CarFeatureResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.CarFeatureQueries;

public record GetCarFeatureByCarIdQuery:IRequest<ServiceResult<List<GetCarFeatureByCarIdQueryResult>>>
{
	public int CarId { get; set; }

	public GetCarFeatureByCarIdQuery(int id)
	{
		CarId = id;
	}
}
