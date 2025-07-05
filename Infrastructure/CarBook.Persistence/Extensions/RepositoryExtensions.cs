using App.Domain.Options;
using App.Persistence.Interceptors;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.BlogInterfaces;
using CarBook.Aplication.Interfaces.CarInterfaces;
using CarBook.Aplication.Interfaces.CarPricingInterfaces;
using CarBook.Aplication.Interfaces.CommentInterfaces;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using CarBook.Aplication.Interfaces.TagCloudInterfaces;
using CarBook.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarBook.Persistence.Extensions
{
	public static class RepositoryExtensions
	{
		public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<CarBookContext>(options =>
			{

				var connectionString = configuration.GetSection(ConnectionStringOption.Key).Get<ConnectionStringOption>();
				options.UseSqlServer(connectionString!.SqlServer, sqlServerOptionsAction =>
				{
					sqlServerOptionsAction.MigrationsAssembly(typeof(PersistenceAssembly).Assembly.FullName);
				});

				options.AddInterceptors(new AuditDbContextInterceptor());

			});
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
			services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
			services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
			services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
			services.AddScoped(typeof(ICommentRepository), typeof(CommentRepository));
			services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));


			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddScoped<AuditDbContextInterceptor>();

			return services;
		}
	}
}
