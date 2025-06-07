using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.FooterAddresses
{
	public class FooterAddressConfiguration: IEntityTypeConfiguration<FooterAddress>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FooterAddress> builder)
		{
			builder.ToTable("FooterAddresses");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Address).IsRequired().HasMaxLength(300);
			builder.Property(x => x.Description).IsRequired().HasMaxLength(200);
			builder.Property(x => x.Phone).IsRequired().HasMaxLength(11);
			builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
		}
	}
}
