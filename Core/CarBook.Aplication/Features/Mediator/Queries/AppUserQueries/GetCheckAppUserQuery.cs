using CarBook.Aplication.Features.Mediator.Results.AppUserResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.AppUserQueries;

public record GetCheckAppUserQuery : IRequest<ServiceResult<GetCheckAppUserQueryResult>>
{
	public string UserName { get; init; } = default!;
	public string Password { get; init; } = default!;
}
