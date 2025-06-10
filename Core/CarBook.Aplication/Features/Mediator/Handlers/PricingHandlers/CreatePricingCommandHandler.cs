using CarBook.Aplication.Features.Mediator.Commands.PricingCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.PricingHandlers
{
	public class CreatePricingCommandHandler(IRepository<Pricing> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<CreatePricingCommand, ServiceResult<CreatePricingByIdCommand>>
	{
		public async Task<ServiceResult<CreatePricingByIdCommand>> Handle(CreatePricingCommand request, CancellationToken cancellationToken)
		{
			var pricing = new Pricing
			{
				Name = request.Name,

			};

			var anyPricing = await repository.AnyAsync(p => p.Name == request.Name);
			if (anyPricing)	return ServiceResult<CreatePricingByIdCommand>.Fail("Bu isimde bir fiyatlandırma zaten var.", HttpStatusCode.Conflict);

			await repository.CreateAsync(pricing);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreatePricingByIdCommand>.SuccessAsCreated(new CreatePricingByIdCommand(pricing.Id),$"api/pricings/{pricing.Id}");
		}
	}
}
