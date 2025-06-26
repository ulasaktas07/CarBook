using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations;

public class CarPricingConfiguration : IEntityTypeConfiguration<CarPricing>
{
	public void Configure(EntityTypeBuilder<CarPricing> builder)
	{
		builder.HasKey(cp => cp.Id);
		builder.Property(cp => cp.Price)
			.HasColumnType("decimal(18,2)")
			.IsRequired();


	}
}
