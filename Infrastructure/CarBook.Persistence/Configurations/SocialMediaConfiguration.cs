using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations
{
	public class SocialMediaConfiguration: IEntityTypeConfiguration<SocialMedia>
	{
		public void Configure(EntityTypeBuilder<SocialMedia> builder)
		{
			builder.HasKey(sm => sm.Id);
			builder.Property(sm => sm.Name).IsRequired().HasMaxLength(50);
			builder.Property(sm => sm.Url).IsRequired().HasMaxLength(100);
			builder.Property(sm => sm.Icon).HasMaxLength(100);
		}
	}

}
