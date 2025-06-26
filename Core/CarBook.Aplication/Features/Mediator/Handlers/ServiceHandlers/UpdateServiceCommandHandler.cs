using CarBook.Aplication.Features.Mediator.Commands.ServiceCommands;
using CarBook.Aplication.Features.Mediator.Results.ServiceResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.ServiceHandlers
{
	public class UpdateServiceCommandHandler(IRepository<Service> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<UpdateServiceCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
		{
			var service = await repository.GetByIdAsync(request.Id);
			if (service == null||service.Id!=request.Id)
				return ServiceResult.Fail("Servis bulunamadı", HttpStatusCode.NotFound);

			service.Title = request.Title;
			service.Description = request.Description;
			service.IconUrl = request.IconUrl;
			repository.Update(service);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
