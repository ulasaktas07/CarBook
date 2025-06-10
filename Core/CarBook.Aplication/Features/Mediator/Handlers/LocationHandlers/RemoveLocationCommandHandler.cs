using CarBook.Aplication.Features.Mediator.Commands.LocationCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.LocationHandlers
{
	public class RemoveLocationCommandHandler(IRepository<Location> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<RemoveLocationCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
		{
			var location = await repository.GetByIdAsync(request.Id);

			repository.Remove(location!);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
