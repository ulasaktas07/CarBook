using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Dto.ContactDtos;

namespace CarBook.Aplication.Interfaces
{
	public interface IContactApiClient
	{
		Task<bool> SendCreateCommandAsync(CreateContactCommand command);

	}
}
