﻿using CarBook.Aplication;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Services;
using CarBook.Persistence.Services;

namespace CarBook.WebUI.Extensions
{
	public static class FrontendExtensions
	{
		public static IServiceCollection AddClients(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddControllersWithViews();
			services.AddHttpClient();
			services.AddScoped<IContactService, ContactService>();
			services.AddScoped<IContactApiClient, ContactApiClient>();
			services.AddScoped<IAboutApiClient, AboutApiClient>();
			services.AddScoped<IFooterAddressApiClient, FooterAddressApiClient>();
			services.AddScoped<ITestimonialApiClient, TestimonialApiClient>();
			services.AddScoped<ICarApiClient, CarApiClient>();
			services.AddScoped<IServiceApiClient, ServiceApiClient>();
			services.AddScoped<IBannerApiClient, BannerApiClient>();
			services.AddScoped<IBlogApiClient, BlogApiClient>();
			services.AddScoped<ICarPricingClient, CarPricingClient>();

			services.AddAutoMapper(typeof(MappingProfile).Assembly);
			return services;
		}
	}
	}
