using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations
{
	public class FooterAddressConfiguration: IEntityTypeConfiguration<FooterAddress>
	{
		public void Configure(EntityTypeBuilder<FooterAddress> builder)
		{

			builder.HasKey(x => x.Id);
			builder.Property(x => x.Address).IsRequired().HasMaxLength(300);
			builder.Property(x => x.Description).IsRequired().HasMaxLength(200);
			builder.Property(x => x.Phone).IsRequired().HasMaxLength(11);
			builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
		}
	}
}
