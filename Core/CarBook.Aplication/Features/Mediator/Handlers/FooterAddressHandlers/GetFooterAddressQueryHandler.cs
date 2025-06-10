using CarBook.Aplication.Features.Mediator.Queries.FooterAddressQueries;
using CarBook.Aplication.Features.Mediator.Results.FooterAddressResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.FooterAddressHandlers
{
	public class GetFooterAddressQueryHandler(IRepository<FooterAddress> repository) : 
		IRequestHandler<GetFooterAddressQuery, ServiceResult<List<GetFooterAddressQueryResult>>>
	{
		public async Task<ServiceResult<List<GetFooterAddressQueryResult>>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
		{
			var footerAddress = await repository.GetAllAsync();

			var result = footerAddress.Select(x => new GetFooterAddressQueryResult(x.Id, x.Description, x.Address, x.Phone, x.Email)).ToList();

			return  ServiceResult<List<GetFooterAddressQueryResult>>.Success(result);

		}
	}

}
