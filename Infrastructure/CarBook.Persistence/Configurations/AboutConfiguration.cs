using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations
{
	public class AboutConfiguration : IEntityTypeConfiguration<About>
	{
		public void Configure(EntityTypeBuilder<About> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
			builder.Property(x => x.Description).IsRequired();
			builder.Property(x => x.ImageUrl).HasMaxLength(100);

		}
	}
}
