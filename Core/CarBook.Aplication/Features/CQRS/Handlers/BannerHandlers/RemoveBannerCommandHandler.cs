using CarBook.Aplication.Features.CQRS.Commands.BannerCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.BannerHandlers
{
	public class RemoveBannerCommandHandler(IRepository<Banner> repository, IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult> Handle(RemoveBannerCommand request)
		{
			var banner = await repository.GetByIdAsync(request.Id);

			repository.Remove(banner!);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}

}
