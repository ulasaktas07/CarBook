using CarBook.Aplication.Features.Mediator.Commands.ServiceCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.ServiceHandlers
{
	public class CreateServiceCommandHandler(IRepository<Service> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<CreateServiceCommand, ServiceResult<CreateServiceByIdCommand>>
	{
		public async Task<ServiceResult<CreateServiceByIdCommand>> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
		{
			var service = new Service
			{
				Title = request.Title,
				Description = request.Description,
				IconUrl = request.IconUrl
			};

			var anyService = await repository.AnyAsync(s => s.Title == service.Title);
			if (anyService)
				return ServiceResult<CreateServiceByIdCommand>.Fail("Bu isimde bir servis zaten var.", HttpStatusCode.Conflict);

			await repository.CreateAsync(service);
		    await unitOfWork.SaveChangesAsync();

			return ServiceResult<CreateServiceByIdCommand>.SuccessAsCreated(new CreateServiceByIdCommand(service.Id),
				$"api/services/{service.Id}");
		}
	}
}
