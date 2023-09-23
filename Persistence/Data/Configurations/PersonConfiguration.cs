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
            .HasColumnName("Description")
            .HasMaxLength(60)
            .IsRequired();

        builder.Property(x => x.Register_date)
            .HasColumnName("Register_date")
            .HasMaxLength(60)
            .IsRequired();


        builder.Property(x => x.Birth_date)
            .HasColumnName("Birth_date")
            .HasColumnType("DateTime")
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Employee)
            .WithMany(x => x.Persons)
            .HasForeignKey(x => x.Id_Employee);  

    }
    
}
