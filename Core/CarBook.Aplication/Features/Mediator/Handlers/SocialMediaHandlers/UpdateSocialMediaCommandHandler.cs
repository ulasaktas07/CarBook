using CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommands;
using CarBook.Aplication.Features.Mediator.Results.SocialMediaResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.SocialMediaHandlers
{
	public class UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<UpdateSocialMediaCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
		{
			var socialMedia = await repository.GetByIdAsync(request.Id);
			if (socialMedia == null || socialMedia.Id != request.Id)
				return ServiceResult.Fail("Sosyal Medya bulunamadı!", HttpStatusCode.NotFound);

			var anySocialMedia = await repository.AnyAsync(x => x.Name == request.Name && x.Id != request.Id);
			if (anySocialMedia)
				return ServiceResult.Fail("Böyle bir sosyal medya zaten mevcut", HttpStatusCode.Conflict);

			socialMedia.Name = request.Name;
			socialMedia.Url = request.Url;
			socialMedia.Icon = request.Icon;
			repository.Update(socialMedia);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
