using CarBook.Aplication.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.SocialMediaQueries;
public record GetSocialMediaQuery : IRequest<ServiceResult<List<GetSocialMediaQueryResult>>>;
