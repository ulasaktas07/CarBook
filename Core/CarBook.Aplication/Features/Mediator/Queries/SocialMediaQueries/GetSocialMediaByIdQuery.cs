using CarBook.Aplication.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.SocialMediaQueries
{
	public record GetSocialMediaByIdQuery:IRequest<ServiceResult<GetSocialMediaByIdQueryResult>>
	{
		public int Id { get; init; }
		public GetSocialMediaByIdQuery(int id)
		{
			Id = id;
		}
	}
}
