using CarBook.Aplication.Features.Mediator.Queries.SocialMediaQueries;
using CarBook.Aplication.Features.Mediator.Results.SocialMediaResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.SocialMediaHandlers
{
	public class GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
		: IRequestHandler<GetSocialMediaQuery, ServiceResult<List<GetSocialMediaQueryResult>>>
	{
		public async Task<ServiceResult<List<GetSocialMediaQueryResult>>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
		{
			var socialMedias = await repository.GetAllAsync();

			var result=socialMedias.Select(s=>new GetSocialMediaQueryResult(s.Id,s.Name,s.Url,s.Icon)).ToList();

			return ServiceResult<List<GetSocialMediaQueryResult>>.Success(result);

		}
	}
}
