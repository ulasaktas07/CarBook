using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.AboutCommands;
using CarBook.Aplication.Features.CQRS.Commands.BannerCommands;
using CarBook.Aplication.Features.CQRS.Commands.BrandCommands;
using CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using CarBook.Aplication.Features.CQRS.Commands.CategoryCommands;
using CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using CarBook.Aplication.Features.CQRS.Results.BannerResults;
using CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
using CarBook.Aplication.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Aplication.Features.Mediator.Commands.LocationCommands;
using CarBook.Aplication.Features.Mediator.Commands.PricingCommands;
using CarBook.Aplication.Features.Mediator.Commands.ReservationCommands;
using CarBook.Aplication.Features.Mediator.Commands.ServiceCommands;
using CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommands;
using CarBook.Aplication.Features.Mediator.Commands.TestimonialCommands;
using CarBook.Aplication.Features.Mediator.Commands.WriterCommands;
using CarBook.Dto.AboutDtos;
using CarBook.Dto.BannerDtos;
using CarBook.Dto.BrandDtos;
using CarBook.Dto.CarDtos;
using CarBook.Dto.CategoryDtos;
using CarBook.Dto.ContactDtos;
using CarBook.Dto.FeatureDtos;
using CarBook.Dto.FooterAddressDtos;
using CarBook.Dto.LocationDtos;
using CarBook.Dto.PricingDtos;
using CarBook.Dto.ReservationDtos;
using CarBook.Dto.ServiceDtos;
using CarBook.Dto.SocialMediaDtos;
using CarBook.Dto.TestimonialDtos;
using CarBook.Dto.WriterDtos;


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

			CreateMap<CreateBannerRequest, CreateBannerCommand>();
			CreateMap<CreateBannerResult, GetBannerQueryResult>();
			CreateMap<UpdateBannerRequest, UpdateBannerCommand>();

			CreateMap<CreateAboutRequest, CreateAboutCommand>();
			CreateMap<UpdateAboutRequest, UpdateAboutCommand>();

			CreateMap<CreateWriterRequest, CreateWriterCommand>();
			CreateMap<UpdateWriterRequest, UpdateWriterCommand>();

			CreateMap<CreateCategoryRequest, CreateCategoryCommand>();
			CreateMap<UpdateCategoryRequest, UpdateCategoryCommand>();

			CreateMap<CreatePricingRequest, CreatePricingCommand>();
			CreateMap<UpdatePricingRequest, UpdatePricingCommand>();

			CreateMap<CreateFooterAddressRequest, CreateFooterAddressCommand>();
			CreateMap<UpdateFooterAddressRequest, UpdateFooterAddressCommand>();

			CreateMap<CreateLocationRequest, CreateLocationCommand>();
			CreateMap<UpdateLocationRequest, UpdateLocationCommand>();

			CreateMap<CreateServiceRequest, CreateServiceCommand>();
			CreateMap<UpdateServiceRequest, UpdateServiceCommand>();

			CreateMap<CreateSocialMediaRequest, CreateSocialMediaCommand>();
			CreateMap<UpdateSocialMediaRequest, UpdateSocialMediaCommand>();

			CreateMap<CreateTestimonialRequest, CreateTestimonialCommand>();
			CreateMap<UpdateTestimonialRequest, UpdateTestimonialCommand>();

			CreateMap<CreateReservationRequest, CreateReservationCommand>();


		}
	}
}
