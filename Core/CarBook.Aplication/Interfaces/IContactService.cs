using CarBook.Dto.CarDtos;
using CarBook.Dto.ContactDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface IContactService
	{
		Task<bool> CreateContactAsync(CreateContactRequest request);

	}
}
