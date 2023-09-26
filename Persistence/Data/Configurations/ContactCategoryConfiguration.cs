using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class ContactCategoryConfiguration : IEntityTypeConfiguration<Contact_category>
{
    public void Configure(EntityTypeBuilder<Contact_category> builder){
        builder.ToTable("Contact_category");
        builder.HasKey(x => x.Id);
        
        // Properties

        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_contactCategory")
            .IsRequired();
    
        builder.Property(x => x.Name)
            .HasMaxLength(60)
            .IsRequired();
    }
}