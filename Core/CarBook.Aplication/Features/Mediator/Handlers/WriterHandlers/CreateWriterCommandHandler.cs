using CarBook.Aplication.Features.Mediator.Commands.WriterCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.WriterHandlers
{
	public class CreateWriterCommandHandler(IRepository<Writer> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<CreateWriterCommand, ServiceResult<CreateWriterByIdCommand>>
	{
		public async Task<ServiceResult<CreateWriterByIdCommand>> Handle(CreateWriterCommand request, CancellationToken cancellationToken)
		{
			var writer = new Writer
			{
				Name = request.Name,
				ImageUrl = request.ImageUrl,
				Description = request.Description
			};
			var anyWriter = await repository.AnyAsync(x => x.Name == writer.Name);
			if (anyWriter)
				return ServiceResult<CreateWriterByIdCommand>.Fail("Bu isimde bir yazar zaten var", HttpStatusCode.Conflict);

			await repository.CreateAsync(writer);
			await unitOfWork.SaveChangesAsync();

			return ServiceResult<CreateWriterByIdCommand>
				.SuccessAsCreated(new CreateWriterByIdCommand(writer.Id), $"api/writers/{writer.Id}");
		}
	}
}
