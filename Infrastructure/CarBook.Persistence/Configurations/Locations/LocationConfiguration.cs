using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Configurations.Locations
{
	public class LocationConfiguration: IEntityTypeConfiguration<Location>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Location> builder)
		{
			builder.HasKey(l => l.Id);
			builder.Property(l => l.Name).IsRequired().HasMaxLength(100);
		}

	}
}
