using CarBook.Aplication.Features.Mediator.Commands.ServiceCommands;
using CarBook.Aplication.Features.Mediator.Results.ServiceResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.ServiceHandlers
{
	public class RemoveServiceCommandHandler(IRepository<Service> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<RemoveServiceCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(RemoveServiceCommand request, CancellationToken cancellationToken)
		{
			var service = await repository.GetByIdAsync(request.Id);
			if (service == null || service.Id != request.Id)
				return ServiceResult.Fail("Servis bulunamadı", HttpStatusCode.NotFound);

		   repository.Remove(service);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
