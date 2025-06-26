using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations
{
	public class LocationConfiguration: IEntityTypeConfiguration<Location>
	{
		public void Configure(EntityTypeBuilder<Location> builder)
		{
			builder.HasKey(l => l.Id);
			builder.Property(l => l.Name).IsRequired().HasMaxLength(100);
		}

	}
}
