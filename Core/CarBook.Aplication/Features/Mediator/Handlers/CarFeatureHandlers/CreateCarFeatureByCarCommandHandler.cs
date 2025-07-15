using CarBook.Aplication.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.CarFeatureInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.CarFeatureHandlers
{
	public class CreateCarFeatureByCarCommandHandler(ICarFeatureRepository repository,IUnitOfWork unitOfWork) 
		: IRequestHandler<CreateCarFeatureByCarCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
		{
			var carFeature = new CarFeature
			{
				CarId = request.CarId,
				FeatureId = request.FeatureId,
				Available = false
			};
			await repository.CreateCarFeatureByCarAsync(carFeature);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
