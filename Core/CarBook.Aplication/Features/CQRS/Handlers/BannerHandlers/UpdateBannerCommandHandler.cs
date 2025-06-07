using CarBook.Aplication.Features.CQRS.Commands.BannerCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.BannerHandlers
{
	public class UpdateBannerCommandHandler(IRepository<Banner> repository,IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult> Handle(UpdateBannerCommand request)
		{
			var banner = await repository.GetByIdAsync(request.Id);
			if (banner == null)	return ServiceResult.Fail("Data Bulunamadı", HttpStatusCode.NotFound);

			banner.Title = request.Title;
			banner.Description = request.Description;
			banner.VideoDescription = request.VideoDescription;
			banner.VideoUrl = request.VideoUrl;
			 repository.Update(banner);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
