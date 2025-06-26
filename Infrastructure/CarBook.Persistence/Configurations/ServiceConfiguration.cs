using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations
{
	public class ServiceConfiguration: IEntityTypeConfiguration<Service>
	{
		public void Configure(EntityTypeBuilder<Service> builder)
		{
			builder.HasKey(s => s.Id);
			builder.Property(s => s.Title).IsRequired().HasMaxLength(50);
			builder.Property(s => s.Description).HasMaxLength(200);
			builder.Property(s => s.IconUrl).HasMaxLength(100);
		}
	}
}
