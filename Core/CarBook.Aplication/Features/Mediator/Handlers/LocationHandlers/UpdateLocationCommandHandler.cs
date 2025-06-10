using CarBook.Aplication.Features.Mediator.Commands.LocationCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.LocationHandlers
{
	public class UpdateLocationCommandHandler(IRepository<Location> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<UpdateLocationCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
		{
			var location = await repository.GetByIdAsync(request.Id);
			if (location == null || location.Id!=request.Id) return ServiceResult.Fail("Location bulunamadı.",HttpStatusCode.NotFound);

			location.Name = request.Name;

			repository.Update(location);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
