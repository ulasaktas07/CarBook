using CarBook.Aplication.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.FooterAddressHandlers
{
	public class RemoveFooterAddressCommandHandler(IRepository<FooterAddress> repository, IUnitOfWork unitOfWork) :
		IRequestHandler<RemoveFooterAddressCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(RemoveFooterAddressCommand request, CancellationToken cancellationToken)
		{
			var footerAddress = await repository.GetByIdAsync(request.Id);

			repository.Remove(footerAddress!);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}

}
