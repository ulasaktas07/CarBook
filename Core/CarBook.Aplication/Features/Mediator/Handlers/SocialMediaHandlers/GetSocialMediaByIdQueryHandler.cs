using CarBook.Aplication.Features.Mediator.Queries.SocialMediaQueries;
using CarBook.Aplication.Features.Mediator.Results.SocialMediaResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.SocialMediaHandlers
{
	public class GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
		: IRequestHandler<GetSocialMediaByIdQuery, ServiceResult<GetSocialMediaByIdQueryResult>>
	{
		public async Task<ServiceResult<GetSocialMediaByIdQueryResult>> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
		{
			var socialMedia = await repository.GetByIdAsync(request.Id);

			if (socialMedia == null||socialMedia.Id!=request.Id)
				return ServiceResult<GetSocialMediaByIdQueryResult>.Fail($"Sosyal Medya bulunamadı!",HttpStatusCode.NotFound);

			var result = new GetSocialMediaByIdQueryResult(socialMedia.Id, socialMedia.Name, socialMedia.Url, socialMedia.Icon);

			return ServiceResult<GetSocialMediaByIdQueryResult>.Success(result);

		}
	}
}
