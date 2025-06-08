using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.ContactHandlers
{
	public class UpdateContactCommandHandler(IRepository<Contact> repository, IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult> Handle(UpdateContactCommand command)
		{
			var contact = await repository.GetByIdAsync(command.Id);
			if (contact is null) return ServiceResult.Fail("Contact bulunamadı",HttpStatusCode.NotFound)
					;
			contact.Name = command.Name;
			contact.Email = command.Email;
			contact.Subject = command.Subject;
			contact.Message = command.Message;
			 repository.Update(contact);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
