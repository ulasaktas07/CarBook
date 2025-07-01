using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.ContactDtos;
namespace CarBook.Persistence.Services
{
	public class ContactService(IContactApiClient contactApiClient, IMapper mapper) : IContactService
	{
			public async Task<bool> CreateContactAsync(CreateContactRequest request)
			{
				var command = mapper.Map<CreateContactCommand>(request);
				return await contactApiClient.SendCreateCommandAsync(command);
			}
	
	}
	}

