﻿using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CarBook.Persistence
{
	public class CarBookContext(DbContextOptions<CarBookContext> options) : DbContext(options)
	{
		public DbSet<AppUser> AppUsers { get; set; } = default!;
		public DbSet<AppRole> AppRoles { get; set; } = default!;
		public DbSet<About> Abouts { get; set; } = default!;
		public DbSet<Banner> Banners { get; set; } = default!;
		public DbSet<Brand> Brands { get; set; } = default!;
		public DbSet<Car> Cars { get; set; } = default!;
		public DbSet<CarDescription> CarDescriptions { get; set; } = default!;
		public DbSet<CarFeature> CarFeatures { get; set; } = default!;
		public DbSet<CarPricing> CarPricings { get; set; } = default!;
		public DbSet<Pricing> Pricing { get; set; } = default!;
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
		public DbSet<Comment> Comments { get; set; } = default!;
		public DbSet<RentACar> RentACars { get; set; } = default!;
		public DbSet<RentACarProcess> RentACarProcesses { get; set; } = default!;
		public DbSet<Customer> Customers { get; set; } = default!;
		public DbSet<Reservation> Reservations { get; set; } = default!;
		public DbSet<Review> Reviews { get; set; } = default!;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Reservation>()
				.HasOne(r => r.PickUpLocation)
				.WithMany(c => c.PickUpReservations)
				.HasForeignKey(r => r.PickUpLocationID)
				.OnDelete(DeleteBehavior.ClientSetNull);

			modelBuilder.Entity<Reservation>()
				.HasOne(r => r.DropOffLocation)
				.WithMany(c => c.DropOffReservations)
				.HasForeignKey(r => r.DropOffLocationID)
				.OnDelete(DeleteBehavior.ClientSetNull);

			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			base.OnModelCreating(modelBuilder);

		}
	}
}
