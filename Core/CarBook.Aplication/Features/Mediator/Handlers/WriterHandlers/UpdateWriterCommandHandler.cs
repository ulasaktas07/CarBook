using CarBook.Aplication.Features.Mediator.Commands.WriterCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.WriterHandlers
{
	public class UpdateWriterCommandHandler(IRepository<Writer> repository, IUnitOfWork unitOfWork) :
		IRequestHandler<UpdateWriterCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(UpdateWriterCommand request, CancellationToken cancellationToken)
		{
			var writer = await repository.GetByIdAsync(request.Id);
			if (writer == null || writer.Id != request.Id)
			{
				return ServiceResult.Fail("Yazar bulunamadı", HttpStatusCode.NotFound);
			}
			writer.Name = request.Name;
			writer.ImageUrl = request.ImageUrl;
			writer.Description = request.Description;
			repository.Update(writer);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}

}
