using CarBook.Aplication.Features.CQRS.Handlers.AboutHadlers;
using CarBook.Aplication.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Aplication.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Aplication.Features.CQRS.Handlers.CarHandlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CarBook.Aplication.Extensions
{
	public static class ServiceExtensions
	{
		public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
		{


			services.AddScoped<GetAboutQueryHandler>();
			services.AddScoped<GetAboutByIdQueryHandler>();
			services.AddScoped<CreateAboutCommandHandler>();
			services.AddScoped<UpdateAboutCommandHandler>();
			services.AddScoped<RemoveAboutCommandHandler>();

			services.AddScoped<GetBannerQueryHandler>();
			services.AddScoped<GetBannerByIdQueryHandler>();
			services.AddScoped<CreateBannerCommandHandler>();
			services.AddScoped<UpdateBannerCommandHandler>();
			services.AddScoped<RemoveBannerCommandHandler>();

			services.AddScoped<GetBrandQueryHandler>();
			services.AddScoped<GetBrandByIdQueryHandler>();
			services.AddScoped<CreateBrandCommandHandler>();
			services.AddScoped<UpdateBrandCommandHandler>();
			services.AddScoped<RemoveBrandCommandHandler>();

			services.AddScoped<GetCarQueryHandler>();
			services.AddScoped<GetCarByIdQueryHandler>();
			services.AddScoped<CreateCarCommandHandler>();
			services.AddScoped<UpdateCarCommandHandler>();
			services.AddScoped<RemoveCarCommandHandler>();
			services.AddScoped<GetCarWithBrandQueryHandler>();




			return services;
		}
	}
}
