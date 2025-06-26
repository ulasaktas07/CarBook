using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations
{
	public class PricingConfiguration: IEntityTypeConfiguration<Pricing>
	{
		public void Configure(EntityTypeBuilder<Pricing> builder)
		{
			builder.HasKey(p => p.Id);
			builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
		}
	}
}
