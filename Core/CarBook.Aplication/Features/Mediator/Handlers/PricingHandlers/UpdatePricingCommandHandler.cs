using CarBook.Aplication.Features.Mediator.Commands.PricingCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.PricingHandlers
{
	public class UpdatePricingCommandHandler(IRepository<Pricing> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<UpdatePricingCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
		{
			var pricing = await repository.GetByIdAsync(request.Id);
			if (pricing == null|| pricing.Id!=request.Id) return ServiceResult.Fail("Fiyatlandırma bulunamadı", HttpStatusCode.NotFound);
			var anyPricing = await repository.AnyAsync(p => p.Name == request.Name && p.Id != request.Id);
			if (anyPricing) return ServiceResult.Fail("Bu isimde bir fiyatlandırma zaten var.", HttpStatusCode.Conflict);
			
			pricing.Name = request.Name;
			repository.Update(pricing);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
