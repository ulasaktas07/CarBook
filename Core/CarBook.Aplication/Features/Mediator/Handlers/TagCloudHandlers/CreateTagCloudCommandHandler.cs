using CarBook.Aplication.Features.Mediator.Commands.TagCloudCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.TagCloudHandlers
{
	public class CreateTagCloudCommandHandler(IRepository<TagCloud> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<CreateTagCloudCommand, ServiceResult<CreateTagCloudByIdCommand>>
	{
		public async Task<ServiceResult<CreateTagCloudByIdCommand>> Handle(CreateTagCloudCommand request, CancellationToken cancellationToken)
		{
			var tagCloud = new TagCloud
			{
				Title = request.Title,
				BlogID = request.BlogID
			};
			await repository.CreateAsync(tagCloud);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateTagCloudByIdCommand>
				.SuccessAsCreated(new CreateTagCloudByIdCommand(tagCloud.Id),$"/api/TagClouds/{tagCloud.Id}");
		}
	}
}
