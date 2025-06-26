using CarBook.Aplication.Features.Mediator.Queries.FooterAddressQueries;
using CarBook.Aplication.Features.Mediator.Results.FooterAddressResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.FooterAddressHandlers
{
	public class GetFooterAddressByIdHandler(IRepository<FooterAddress> repository) : 
		IRequestHandler<GetFooterAddressByIdQuery, ServiceResult<GetFooterAddressByIdQueryResult>>
	{
		public async Task<ServiceResult<GetFooterAddressByIdQueryResult>> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
		{
			var footerAddress = await repository.GetByIdAsync(request.Id);
			if (footerAddress == null||footerAddress.Id!=request.Id)
				return ServiceResult<GetFooterAddressByIdQueryResult>.Fail("Footer address bulunamadı", HttpStatusCode.NotFound);
			
			var result = new GetFooterAddressByIdQueryResult(footerAddress.Id, footerAddress.Description, footerAddress.Address, footerAddress.Phone, footerAddress.Email);
			return ServiceResult<GetFooterAddressByIdQueryResult>.Success(result);
		}
	}
}
