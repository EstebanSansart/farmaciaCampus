using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class ContactTypeConfiguration : IEntityTypeConfiguration<Contact_Type>
{
    public void Configure(EntityTypeBuilder<Contact_Type> builder){
        builder.ToTable("Contact_type");
        builder.HasKey(x => x.Id);
        
        // Properties

        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_contactType")
            .IsRequired();
    
        builder.Property(x => x.Name)
            .HasMaxLength(60)
            .IsRequired();

        // Keys
      

    
    }
    
}