using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder){
        builder.ToTable("City");
        builder.HasKey(x => x.Id);
        
        // Properties
        
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_city")
            .IsRequired();
    
        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasMaxLength(60)
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Department)
            .WithMany(x => x.Cities)
            .HasForeignKey(x => x.Id_department);  

        builder.HasData(
            new {
                Id=1,
                Name = "Medellin",
                Id_department = 1
            },
            new {
                Id=2,
                Name = "Apartado",
                Id_department = 1
            },
            new {
                Id=3,
                Name = "Arboletes",
                Id_department = 1
            },
            new {
                Id=4,
                Name = "Rio negro",
                Id_department = 1
            }
        );
    }
}
