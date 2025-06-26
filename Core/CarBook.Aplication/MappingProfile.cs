using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Dto.ContactDtos;


namespace CarBook.Aplication
{
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateContactRequest, CreateContactCommand>();
		}
	}
}
