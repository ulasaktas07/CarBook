using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configurations
{
	public class ContactConfiguration : IEntityTypeConfiguration<Contact>
	{
		public void Configure(EntityTypeBuilder<Contact> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
			builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
			builder.Property(c => c.Subject).IsRequired().HasMaxLength(50);
			builder.Property(c => c.Message).IsRequired().HasMaxLength(250);


		}
	}
}
