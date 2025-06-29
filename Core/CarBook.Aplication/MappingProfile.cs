using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Dto.CarDtos;
using CarBook.Dto.ContactDtos;


namespace CarBook.Aplication
{
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateContactRequest, CreateContactCommand>();
			CreateMap<CreateCarRequest, CreateCarCommand>();
			CreateMap<ResultCarDto, UpdateCarCommand>();
		}
	}
}
