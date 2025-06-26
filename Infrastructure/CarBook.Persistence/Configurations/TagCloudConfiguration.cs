using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations
{
	public class TagCloudConfiguration : IEntityTypeConfiguration<TagCloud>
	{
		public void Configure(EntityTypeBuilder<TagCloud> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
			builder.HasOne(x => x.Blog)
				.WithMany(b => b.TagClouds)
				.HasForeignKey(x => x.BlogID)
				.OnDelete(DeleteBehavior.Cascade);

		}
	}
}
