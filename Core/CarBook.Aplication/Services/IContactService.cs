using CarBook.Dto.ContactDtos;

namespace CarBook.Aplication.Services;

public interface IContactService
{
	Task<bool> CreateContactAsync(CreateContactRequest request);

}
