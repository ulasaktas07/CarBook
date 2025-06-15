using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CarBook.Persistence.Configurations
{
	public class BlogConfiguration : IEntityTypeConfiguration<Blog>
	{
		public void Configure(EntityTypeBuilder<Blog> builder)
		{
			builder.HasKey(b => b.Id);
			builder.Property(b => b.Title).IsRequired().HasMaxLength(200);
			builder.Property(b => b.CoverImageUrl).IsRequired().HasMaxLength(500);
		}
	}
}
