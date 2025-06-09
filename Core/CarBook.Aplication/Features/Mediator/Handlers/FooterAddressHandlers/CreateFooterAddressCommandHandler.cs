using CarBook.Aplication.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.FooterAddressHandlers
{
	public class CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository, IUnitOfWork unitOfWork) :
		IRequestHandler<CreateFooterAddressCommand, ServiceResult<CreateFooterAddressByIdCommand>>
	{
		public async Task<ServiceResult<CreateFooterAddressByIdCommand>> Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
		{
			var footerAddress = new FooterAddress
			{
				Description = request.Description,
				Address = request.Address,
				Phone = request.Phone,
				Email = request.Email
			};

			await repository.CreateAsync(footerAddress);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateFooterAddressByIdCommand>.SuccessAsCreated(new CreateFooterAddressByIdCommand(footerAddress.Id),
				$"api/footer-addresses/{footerAddress.Id}");
		}
	}
}
