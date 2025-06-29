using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Persistence;
using CarBook.Persistence.Client;
using CarBook.Persistence.Services;

namespace CarBook.WebUI.Extensions
{
	public static class FrontendExtensions
	{
		public static IServiceCollection AddClients(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddControllersWithViews();
			services.AddHttpClient();
			services.AddScoped<ICarService, CarService>();
			services.AddScoped<IContactService, ContactService>();
			services.AddScoped<IFeatureService, FeatureService>();
			services.AddScoped<IBrandService, BrandService>();
			services.AddScoped<IContactApiClient, ContactApiClient>();
			services.AddScoped<IAboutApiClient, AboutApiClient>();
			services.AddScoped<IFooterAddressApiClient, FooterAddressApiClient>();
			services.AddScoped<ITestimonialApiClient, TestimonialApiClient>();
			services.AddScoped<ICarApiClient, CarApiClient>();
			services.AddScoped<IServiceApiClient, ServiceApiClient>();
			services.AddScoped<IBannerApiClient, BannerApiClient>();
			services.AddScoped<IBlogApiClient, BlogApiClient>();
			services.AddScoped<ICarPricingClient, CarPricingClient>();
			services.AddScoped<ICategoryApiClient, CategoryApiClient>();
			services.AddScoped<ITagCloudApiClient, TagCloudApiClient>();
			services.AddScoped<IBrandApiClient, BrandApiClient>();
			services.AddScoped<IFeatureApiClient, FeatureApiClient>();


			services.AddAutoMapper(typeof(MappingProfile).Assembly);
			return services;
		}
	}
}
