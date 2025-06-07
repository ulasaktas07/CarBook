using CarBook.Aplication.Features.CQRS.Commands.BannerCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Features.CQRS.Handlers.BannerHandlers
{
	public class CreateBannerCommandHandler(IRepository<Banner> repository, IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult<CreateBannerByIdCommand>> Handle(CreateBannerCommand command)
		{
			var banner = new Banner
			{
				Title = command.Title,
				Description = command.Description,
				VideoDescription = command.VideoDescription,
				VideoUrl = command.VideoUrl,
			};
			await repository.CreateAsync(banner);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateBannerByIdCommand>.SuccessAsCreated(new CreateBannerByIdCommand(banner.Id), $"api/banners/{banner.Id}");
		}
	}
}
