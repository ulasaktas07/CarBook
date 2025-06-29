using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
using CarBook.Dto.CarDtos;
using CarBook.Dto.ContactDtos;
using CarBook.Dto.FeatureDtos;


namespace CarBook.Aplication
{
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateContactRequest, CreateContactCommand>();
			CreateMap<CreateCarRequest, CreateCarCommand>();
			CreateMap<ResultCarDto, UpdateCarCommand>();
			CreateMap<CreateFeatureRequest, CreateFeatureCommand>();
			CreateMap<ResultFeatureDto, UpdateFeatureCommand>();

		}
	}
}
