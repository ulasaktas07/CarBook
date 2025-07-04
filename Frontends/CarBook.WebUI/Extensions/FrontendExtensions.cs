using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Interfaces.Services;
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
			services.AddScoped<IBannerService, BannerService>();
			services.AddScoped<IBrandService, BrandService>();
			services.AddScoped<IAboutService, AboutService>();
			services.AddScoped<IWriterService, WriterService>();
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IPricingService, PricingService>();
			services.AddScoped<IFooterAddressService, FooterAddressService>();
			services.AddScoped<ILocationService, LocationService>();
			services.AddScoped<IServiceService, ServiceService>();


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
			services.AddScoped<IWriterApiClient, WriterApiClient>();
			services.AddScoped<ICommentApiClient, CommentApiClient>();
			services.AddScoped<IPricingApiClient, PricingApiClient>();
			services.AddScoped<ILocationApiClient, LocationApiClient>();


			services.AddAutoMapper(typeof(MappingProfile).Assembly);
			return services;
		}
	}
}
