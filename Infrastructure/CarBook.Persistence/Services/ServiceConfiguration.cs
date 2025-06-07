using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Services
{
	public class ServiceConfiguration: IEntityTypeConfiguration<Service>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Service> builder)
		{
			builder.HasKey(s => s.Id);
			builder.Property(s => s.Title).IsRequired().HasMaxLength(50);
			builder.Property(s => s.Description).HasMaxLength(200);
			builder.Property(s => s.IconUrl).HasMaxLength(100);
		}
	}
}
