using CarBook.Aplication.Features.Mediator.Commands.LocationCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.LocationHandlers
{
	public class CreateLocationCommandHandler(IRepository<Location> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<CreateLocationCommand, ServiceResult<CreateLocationByIdCommand>>
	{
		public async Task<ServiceResult<CreateLocationByIdCommand>> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
		{
			var location = new Location
			{
				Name = request.Name
			};
			await repository.CreateAsync(location);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateLocationByIdCommand>.SuccessAsCreated(new CreateLocationByIdCommand(location.Id),
				$"api/locations/{location.Id}");
		}
	}
}
