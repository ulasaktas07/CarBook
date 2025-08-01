﻿using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Persistence;
using CarBook.Persistence.Client;
using CarBook.Persistence.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace CarBook.WebUI.Extensions
{
	public static class FrontendExtensions
	{
		public static IServiceCollection AddClients(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddControllersWithViews();
			services.AddHttpClient();
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
				.AddCookie(JwtBearerDefaults.AuthenticationScheme,options =>
				{
					options.LoginPath = "/Login/Index";
					options.LogoutPath = "/Login/LogOut";
					options.AccessDeniedPath = "/Pages/AccessDenied";
					options.Cookie.SameSite = SameSiteMode.Strict;
					options.Cookie.HttpOnly = true;
					options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
					options.Cookie.Name = "CarBookJwt";
				});

			services.AddHttpContextAccessor();


			services.AddScoped<ICarService, CarService>();
			services.AddScoped<IContactService, ContactService>();
			services.AddScoped<IFeatureService, FeatureService>();
			services.AddScoped<IBannerService, BannerService>();
			services.AddScoped<IBrandService, BrandService>();
			services.AddScoped<IAboutService, AboutService>();
			services.AddScoped<IWriterService, WriterService>();
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IPricingService, PricingService>();
			services.AddScoped<IFooterAddressService, FooterAddressService>();
			services.AddScoped<ILocationService, LocationService>();
			services.AddScoped<IServiceService, ServiceService>();
			services.AddScoped<ISocialMediaService, SocialMediaService>();
			services.AddScoped<ITestimonialService, TestimonialService>();
			services.AddScoped<IReservationService, ReservationService>();
			services.AddScoped<ICommentService, CommentService>();
			services.AddScoped<IRegisterService, RegisterService>();
			services.AddScoped<ILoginService, LoginService>();




			services.AddScoped<IContactApiClient, ContactApiClient>();
			services.AddScoped<IAboutApiClient, AboutApiClient>();
			services.AddScoped<IFooterAddressApiClient, FooterAddressApiClient>();
			services.AddScoped<ITestimonialApiClient, TestimonialApiClient>();
			services.AddScoped<ICarApiClient, CarApiClient>();
			services.AddScoped<IServiceApiClient, ServiceApiClient>();
			services.AddScoped<IBannerApiClient, BannerApiClient>();
			services.AddScoped<IBlogApiClient, BlogApiClient>();
			services.AddScoped<ICarPricingApiClient, CarPricingApiClient>();
			services.AddScoped<ICategoryApiClient, CategoryApiClient>();
			services.AddScoped<ITagCloudApiClient, TagCloudApiClient>();
			services.AddScoped<IBrandApiClient, BrandApiClient>();
			services.AddScoped<IFeatureApiClient, FeatureApiClient>();
			services.AddScoped<IWriterApiClient, WriterApiClient>();
			services.AddScoped<ICommentApiClient, CommentApiClient>();
			services.AddScoped<IPricingApiClient, PricingApiClient>();
			services.AddScoped<ILocationApiClient, LocationApiClient>();
			services.AddScoped<ISocialMediaApiClient, SocialMediaApiClient>();
			services.AddScoped<IStatisticsApiClient, StatisticsApiClient>();
			services.AddScoped<IRentACarApiClient, RentACarApiClient>();
			services.AddScoped<IReservationApiClient, ReservationApiClient>();
			services.AddScoped<ICarFeatureApiClient, CarFeatureApiClient>();
			services.AddScoped<ICarDescriptionApiClient, CarDescriptionApiClient>();
			services.AddScoped<IReviewApiClient, ReviewApiClient>();
			services.AddScoped<IRegisterApiClient, RegisterApiClient>();
			services.AddScoped<ILoginApiClient, LoginApiClient>();


			services.AddAutoMapper(typeof(MappingProfile).Assembly);
			return services;
		}
	}
}
