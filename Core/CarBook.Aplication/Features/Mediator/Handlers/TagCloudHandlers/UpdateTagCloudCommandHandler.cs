using CarBook.Aplication.Features.Mediator.Commands.TagCloudCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.TagCloudHandlers
{
	public class UpdateTagCloudCommandHandler(IRepository<TagCloud> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<UpdateTagCloudCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(UpdateTagCloudCommand request, CancellationToken cancellationToken)
		{
			var tagCloud = await repository.GetByIdAsync(request.Id);
			if (tagCloud == null)
			{
				return ServiceResult.Fail("Tag cloud not found.",HttpStatusCode.NotFound);
			}
			tagCloud.Title = request.Title;
			tagCloud.BlogID = request.BlogID;
			repository.Update(tagCloud);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
