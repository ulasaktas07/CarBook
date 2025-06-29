﻿using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.BrandCommands;
using CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
using CarBook.Dto.BrandDtos;
using CarBook.Dto.CarDtos;
using CarBook.Dto.ContactDtos;
using CarBook.Dto.FeatureDtos;


namespace CarBook.Persistence
{
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateContactRequest, CreateContactCommand>();
			CreateMap<CreateCarRequest, CreateCarCommand>();
			CreateMap<UpdateCarRequest, UpdateCarCommand>();
			CreateMap<CreateFeatureRequest, CreateFeatureCommand>();
			CreateMap<UpdateFeatureRequest, UpdateFeatureCommand>();
			CreateMap<CreateBrandRequest, CreateBrandCommand>();
			CreateMap<UpdateBrandRequest, UpdateBrandCommand>();

		}
	}
}
