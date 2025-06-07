using CarBook.Aplication.Features.Handlers.AboutHadlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CarBook.Aplication.Extensions
{
	public static class ServiceExtensions
	{
		public static IServiceCollection AddServices(this IServiceCollection services,IConfiguration configuration)
		{


			services.AddScoped<GetAboutQueryHandler>();
			services.AddScoped<GetAboutByIdQueryHandler>();
			services.AddScoped<CreateAboutCommandHandler>();
			services.AddScoped<UpdateAboutCommandHandler>();
			services.AddScoped<RemoveAboutCommandHandler>();

			return services;
		}
	}
}
