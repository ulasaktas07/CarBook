using CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.SocialMediaHandlers
{
	public class CreateSocialMediaCommandHandler(IRepository<SocialMedia> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<CreateSocialMediaCommand, ServiceResult<CreateSocialMediaByIdCommand>>
	{
		public async Task<ServiceResult<CreateSocialMediaByIdCommand>> Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
		{
			var socialMedia = new SocialMedia
			{
				Name = request.Name,
				Url = request.Url,
				Icon = request.Icon
			};

			var anySocialMedia = await repository.AnyAsync(x => x.Name == socialMedia.Name);

			if(anySocialMedia) return ServiceResult<CreateSocialMediaByIdCommand>.Fail("Böyle bir sosyal medya zaten mevcut", HttpStatusCode.Conflict);

			await repository.CreateAsync(socialMedia);
			await unitOfWork.SaveChangesAsync();

			return ServiceResult<CreateSocialMediaByIdCommand>.SuccessAsCreated(new CreateSocialMediaByIdCommand(socialMedia.Id), $"/api/SocialMedias/{socialMedia.Id}");
		}
	}
}
