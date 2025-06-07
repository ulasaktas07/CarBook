using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Features
{
	public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
	{
		public void Configure(EntityTypeBuilder<Feature> builder)
		{
			builder.HasKey(f => f.Id);
			builder.Property(f => f.Name).IsRequired().HasMaxLength(100);
		}
	}
}
