using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Configurations.Pricings
{
	public class PricingConfiguration: IEntityTypeConfiguration<Pricing>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pricing> builder)
		{
			builder.HasKey(p => p.Id);
			builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
		}
	}
}
