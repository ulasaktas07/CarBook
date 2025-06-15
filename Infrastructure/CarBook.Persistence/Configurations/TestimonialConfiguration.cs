using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations
{
	public class TestimonialConfiguration: IEntityTypeConfiguration<Testimonial>
	{
		public void Configure(EntityTypeBuilder<Testimonial> builder)
		{
			builder.HasKey(t => t.Id);
			builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
			builder.Property(t => t.Title).IsRequired().HasMaxLength(100);
			builder.Property(t => t.Comment).HasMaxLength(250);
			builder.Property(t => t.ImageUrl).HasMaxLength(100);

		}
	}

}
