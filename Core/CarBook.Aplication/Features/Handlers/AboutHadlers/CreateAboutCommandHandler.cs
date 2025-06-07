using CarBook.Aplication.Features.Commands.AboutCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Features.Handlers.AboutHadlers
{
	public class CreateAboutCommandHandler(IRepository<About> repository, IUnitOfWork unitOfWork)
	{

		public async Task<ServiceResult<CreateByIdAboutCommand>> Handle(CreateAboutCommand request)
		{
			var about = new About
			{
				Title = request.Title,
				Description = request.Description,
				ImageUrl = request.ImageUrl
			};
			await repository.CreateAsync(about);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateByIdAboutCommand>.SuccessAsCreated(new CreateByIdAboutCommand(about.Id),$"api/abouts/{about.Id}");

		}
	}
}
