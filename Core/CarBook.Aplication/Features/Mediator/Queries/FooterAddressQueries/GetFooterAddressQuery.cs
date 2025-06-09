using CarBook.Aplication.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.FooterAddressQueries
{
	public record GetFooterAddressQuery : IRequest<ServiceResult<List<GetFooterAddressQueryResult>>>
	{
	}
}
