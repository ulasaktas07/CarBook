using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations.CarFeatures
{
	public class CarFeatureConfiguration : IEntityTypeConfiguration<CarFeature>
	{
		public void Configure(EntityTypeBuilder<CarFeature> builder)
		{
			builder.HasKey(cf => cf.Id);
		}
	}
}
