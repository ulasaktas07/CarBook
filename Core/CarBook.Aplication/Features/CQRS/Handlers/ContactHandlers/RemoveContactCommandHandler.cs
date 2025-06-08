using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.ContactHandlers
{
	public class RemoveContactCommandHandler(IRepository<Contact> repository,IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult> Handle(RemoveContactCommand command)
		{
			var contact = await repository.GetByIdAsync(command.Id);
			repository.Remove(contact!);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
