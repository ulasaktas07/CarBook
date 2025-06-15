using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations
{
	public class BannerConfiguration : IEntityTypeConfiguration<Banner>
	{
		public void Configure(EntityTypeBuilder<Banner> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
			builder.Property(x => x.Description).HasMaxLength(300);
			builder.Property(x => x.VideoDescription).HasMaxLength(200);
			builder.Property(x => x.VideoUrl).HasMaxLength(150);
		}
	}
}
