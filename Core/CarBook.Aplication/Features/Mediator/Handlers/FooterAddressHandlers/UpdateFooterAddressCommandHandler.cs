using CarBook.Aplication.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.FooterAddressHandlers
{
	public class UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository, IUnitOfWork unitOfWork) :
		IRequestHandler<UpdateFooterAddressCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
		{
			var footerAddress = await repository.GetByIdAsync(request.Id);
			if (footerAddress == null || footerAddress.Id != request.Id) 
				return ServiceResult.Fail("Footer address bulunamadı",HttpStatusCode.NotFound);
	
			footerAddress.Address = request.Address;
			footerAddress.Phone = request.Phone;
			footerAddress.Email = request.Email;
			repository.Update(footerAddress);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
