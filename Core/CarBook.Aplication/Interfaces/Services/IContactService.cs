using CarBook.Dto.ContactDtos;

namespace CarBook.Aplication.Interfaces.Services;

public interface IContactService
{
	Task<bool> CreateContactAsync(CreateContactRequest request);

}
