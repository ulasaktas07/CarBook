using CarBook.Aplication.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.FooterAddressQueries
{
	public record GetFooterAddressByIdQuery:IRequest<ServiceResult<GetFooterAddressByIdQueryResult>>
	{
		public int Id { get; }
		public GetFooterAddressByIdQuery(int id)
		{
			Id = id;
		}
	}
}
