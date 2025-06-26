using CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
	public class RemoveCarCommandHandler(IRepository<Car> repository,IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult> Handle(RemoveCarCommand command)
		{
			var car = await repository.GetByIdAsync(command.Id);
			repository.Remove(car!);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
