using CarBook.Aplication.Features.CQRS.Commands.AboutCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.AboutHadlers
{
	public class RemoveAboutCommandHandler(IRepository<About> repository, IUnitOfWork unitOfWork)
	{

		public async Task<ServiceResult> Handle(RemoveAboutCommand request)
		{
			var about = await repository.GetByIdAsync(request.Id);
			repository.Remove(about!);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);

		}
	}
}
