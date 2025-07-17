using CarBook.Aplication.Features.Mediator.Results.CarDescriptionResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.CarDescriptionQueries
{
	public record GetCarDescriptionQuery:IRequest<ServiceResult<GetCarDescriptionQueryResult>>
	{
		public int Id { get; init; }
		public GetCarDescriptionQuery(int id)
		{
			Id = id;
		}
	}
}
