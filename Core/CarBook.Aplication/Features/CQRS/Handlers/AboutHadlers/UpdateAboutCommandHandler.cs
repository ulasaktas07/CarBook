using CarBook.Aplication.Features.CQRS.Commands.AboutCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.AboutHadlers
{
	public class UpdateAboutCommandHandler(IUnitOfWork unitOfWork, IRepository<About> repository)
	{

		public async Task<ServiceResult> Handle(UpdateAboutCommand request)
		{
			var about = await repository.GetByIdAsync(request.Id);
			if (about == null) return ServiceResult.Fail( "Data Bulunamadı",HttpStatusCode.NotFound);

			about.Title = request.Title;
			about.Description = request.Description;
			about.ImageUrl = request.ImageUrl;
			repository.Update(about);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);

		}
	}

}

