using CarBook.Aplication.Features.Mediator.Commands.PricingCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.PricingHandlers
{
	public class RemovePricingCommandHandler(IRepository<Pricing> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<RemovePricingCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(RemovePricingCommand request, CancellationToken cancellationToken)
		{
			var pricing = await repository.GetByIdAsync(request.Id);
			if (pricing == null || pricing.Id != request.Id)
				return ServiceResult.Fail("Fiyatlandırma bulunamadı", System.Net.HttpStatusCode.NotFound);

			repository.Remove(pricing);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
