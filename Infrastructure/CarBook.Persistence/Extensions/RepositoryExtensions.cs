using App.Domain.Options;
using App.Persistence.Interceptors;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.BlogInterfaces;
using CarBook.Aplication.Interfaces.CarDescriptionInterfaces;
using CarBook.Aplication.Interfaces.CarFeatureInterfaces;
using CarBook.Aplication.Interfaces.CarInterfaces;
using CarBook.Aplication.Interfaces.CarPricingInterfaces;
using CarBook.Aplication.Interfaces.CommentInterfaces;
using CarBook.Aplication.Interfaces.RentACarInterfaces;
using CarBook.Aplication.Interfaces.ReviewInterfaces;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using CarBook.Aplication.Interfaces.TagCloudInterfaces;
using CarBook.Aplication.Tools;
using CarBook.Persistence.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
			{
				options.RequireHttpsMetadata = false;
				options.TokenValidationParameters=new TokenValidationParameters
				{
					
					ValidAudience =JwtTokenDefaults.ValidAudience,
					ValidIssuer = JwtTokenDefaults.ValidIssuer,
					ClockSkew= TimeSpan.Zero,
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
					ValidateLifetime= true,
					ValidateIssuerSigningKey = true
				};

			});

			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
			services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
			services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
			services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
			services.AddScoped(typeof(ICommentRepository), typeof(CommentRepository));
			services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
			services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
			services.AddScoped(typeof(ICarDescriptionRepository), typeof(CarDescriptionRepository));
			services.AddScoped(typeof(IReviewRepository), typeof(ReviewRepository));
			services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));



			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddScoped<AuditDbContextInterceptor>();

			return services;
		}
	}
}
