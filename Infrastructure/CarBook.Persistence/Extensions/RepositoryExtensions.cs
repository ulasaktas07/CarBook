using App.Domain.Options;
using App.Persistence.Interceptors;
using CarBook.Aplication.Interfaces;
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


			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddScoped<AuditDbContextInterceptor>();

			return services;
		}
	}
}
