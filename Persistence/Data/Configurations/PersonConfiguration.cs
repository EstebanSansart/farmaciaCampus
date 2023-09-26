using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder){
        builder.ToTable("Person");
        builder.HasKey(x => x.Id);
        
        // Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Person")
            .IsRequired();
    
        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasMaxLength(60)
            .IsRequired();

        builder.Property(x => x.Register_date)
            .HasColumnName("Register_Date")
            .HasMaxLength(60)
            .IsRequired();


        builder.Property(x => x.Birth_date)
            .HasColumnName("Birth_Date")
            .HasColumnType("DateTime")
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Document_type)
            .WithMany(x => x.Persons)
            .HasForeignKey(x => x.Id_Document_type);

        builder.HasOne(x => x.Type_Person)
            .WithMany(x => x.Persons)
            .HasForeignKey(x => x.Id_Type_Person);
    }
    
}
