using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder){
        builder.ToTable("Contact");
        builder.HasKey(x => x.Id);
        
        //--Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_contact")
            .IsRequired();
    
        builder.Property(x => x.Description)
            .HasMaxLength(60)
            .IsRequired();

        builder.HasOne(x => x.Person)
            .WithMany(x => x.Contacts)
            .HasForeignKey(x => x.Id_person);

        builder.HasOne(x => x.Contact_Type)
            .WithMany(x => x.Contacts)
            .HasForeignKey(x => x.Id_contact_type);   

        builder.HasOne(x => x.Contact_Category)
            .WithMany(x => x.Contacts)
            .HasForeignKey(x => x.Id_contact_category);   


            

    }
    
}