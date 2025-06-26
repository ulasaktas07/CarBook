using CarBook.Aplication.Features.CQRS.Commands.AboutCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Features.CQRS.Handlers.AboutHadlers
{
	public class CreateAboutCommandHandler(IRepository<About> repository, IUnitOfWork unitOfWork)
	{

		public async Task<ServiceResult<CreateAboutByIdCommand>> Handle(CreateAboutCommand request)
		{
			var about = new About
			{
				Title = request.Title,
				Description = request.Description,
				ImageUrl = request.ImageUrl
			};
			await repository.CreateAsync(about);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateAboutByIdCommand>.SuccessAsCreated(new CreateAboutByIdCommand(about.Id),$"api/abouts/{about.Id}");

		}
	}
}
