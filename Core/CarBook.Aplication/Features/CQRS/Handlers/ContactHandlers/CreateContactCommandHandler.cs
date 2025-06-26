using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Features.CQRS.Handlers.ContactHandlers
{
	public class CreateContactCommandHandler(IRepository<Contact> repository,IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult<CreateContactByIdCommand>> Handle(CreateContactCommand command)
		{
			var contact = new Contact
			{
				Name = command.Name,
				Email = command.Email,
				Subject = command.Subject,
				Message = command.Message
			};
			await repository.CreateAsync(contact);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateContactByIdCommand>.SuccessAsCreated(new CreateContactByIdCommand(contact.Id),$"api/contacts/{contact.Id}");
		}
	}
}
