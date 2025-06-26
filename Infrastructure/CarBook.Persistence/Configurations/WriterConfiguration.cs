using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarBook.Persistence.Configurations
{
	public class WriterConfiguration : IEntityTypeConfiguration<Writer>
	{
		public void Configure(EntityTypeBuilder<Writer> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
			builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
			builder.Property(x => x.ImageUrl).HasMaxLength(200);
		}
	}
}
