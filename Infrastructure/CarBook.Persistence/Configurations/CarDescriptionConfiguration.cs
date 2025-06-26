using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations
{
	public class CarDescriptionConfiguration : IEntityTypeConfiguration<CarDescription>
	{
		public void Configure(EntityTypeBuilder<CarDescription> builder)
		{
			builder.HasKey(cd => cd.Id);
			builder.Property(cd => cd.Details).IsRequired().HasMaxLength(500);
		}
	}
}
