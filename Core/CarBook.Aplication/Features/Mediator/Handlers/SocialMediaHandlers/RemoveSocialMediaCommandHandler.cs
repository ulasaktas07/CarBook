using CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.SocialMediaHandlers
{
	public class RemoveSocialMediaCommandHandler(IRepository<SocialMedia> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<RemoveSocialMediaCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(RemoveSocialMediaCommand request, CancellationToken cancellationToken)
		{
			var socialMedia = await repository.GetByIdAsync(request.Id);
			if (socialMedia == null || socialMedia.Id != request.Id)
				return ServiceResult.Fail("Sosyal Medya bulunamadı!", HttpStatusCode.NotFound);

			repository.Remove(socialMedia);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
