using CarBook.Aplication.Features.Mediator.Commands.WriterCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.WriterHandlers
{
	public class RemoveWriterCommandHandler(IRepository<Writer> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<RemoveWriterCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(RemoveWriterCommand request, CancellationToken cancellationToken)
		{
			var writer = await repository.GetByIdAsync(request.Id);
			if (writer == null)
			{
				return ServiceResult.Fail("Yazar bulunamadı",HttpStatusCode.NotFound);
			}
			 repository.Remove(writer);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
