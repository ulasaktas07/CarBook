using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarBook.Persistence.Configurations.Cars
{
	public class CarConfiguration : IEntityTypeConfiguration<Car>
	{
		public void Configure(EntityTypeBuilder<Car> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.BrandID).IsRequired();
			builder.Property(c => c.Model).IsRequired().HasMaxLength(100);
			builder.Property(c => c.CoverImageUrl).IsRequired().HasMaxLength(150);
			builder.Property(c => c.Km).IsRequired();
			builder.Property(c => c.Transmission).IsRequired().HasMaxLength(50);
			builder.Property(c => c.Seat).IsRequired();
			builder.Property(c => c.Lunggage).IsRequired();
			builder.Property(c => c.Fuel).HasMaxLength(50);
			builder.Property(c => c.BigImageUrl).IsRequired().HasMaxLength(150);

		}
	}
}
