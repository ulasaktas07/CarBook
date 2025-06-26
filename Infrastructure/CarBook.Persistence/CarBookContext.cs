using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CarBook.Persistence
{
	public class CarBookContext(DbContextOptions<CarBookContext> options) : DbContext(options)
	{
		public DbSet<About> Abouts { get; set; } = default!;
		public DbSet<Banner> Banners { get; set; } = default!;
		public DbSet<Brand> Brands { get; set; } = default!;
		public DbSet<Car> Cars { get; set; } = default!;
		public DbSet<CarDescription> CarDescriptions { get; set; } = default!;
		public DbSet<CarFeature> CarFeatures { get; set; } = default!;
		public DbSet<CarPricing> CarPricings { get; set; } = default!;
		public DbSet<Category> Categories { get; set; } = default!;
		public DbSet<Contact> Contacts { get; set; } = default!;
		public DbSet<Feature> Features { get; set; } = default!;
		public DbSet<FooterAddress> FooterAddresses { get; set; } = default!;
		public DbSet<Location> Locations { get; set; } = default!;
		public DbSet<Service> Services { get; set; } = default!;
		public DbSet<SocialMedia> SocialMedias { get; set; } = default!;
		public DbSet<Testimonial> Testimonials { get; set; } = default!;
		public DbSet<Writer> Writers { get; set; } = default!;
		public DbSet<Blog> Blogs { get; set; } = default!;
		public DbSet<TagCloud> TagClouds { get; set; } = default!;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			base.OnModelCreating(modelBuilder);

		}
	}
}
