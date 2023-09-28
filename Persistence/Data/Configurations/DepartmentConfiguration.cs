using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder){
        builder.ToTable("Department");
        builder.HasKey(x => x.Id);
        
        // Properties
        
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Department")
            .IsRequired();
    
        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasMaxLength(60)
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Country)
            .WithMany(x => x.Departments)
            .HasForeignKey(x => x.Id_country); 

        builder.HasData(
            new {
                Id=1,
                Name = "Antioquia",
                Id_country = 1,                    
            }
        ); 
    }
    
}
