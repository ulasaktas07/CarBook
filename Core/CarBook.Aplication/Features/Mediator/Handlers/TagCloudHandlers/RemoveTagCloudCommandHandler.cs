using CarBook.Aplication.Features.Mediator.Commands.TagCloudCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.TagCloudHandlers
{
	public class RemoveTagCloudCommandHandler(IRepository<TagCloud> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<RemoveTagCloudCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(RemoveTagCloudCommand request, CancellationToken cancellationToken)
		{
			var tagCloud = await repository.GetByIdAsync(request.Id);
			if (tagCloud == null)
			{
				return ServiceResult.Fail("Tag cloud not found.",HttpStatusCode.NotFound);
			}
			repository.Remove(tagCloud);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
