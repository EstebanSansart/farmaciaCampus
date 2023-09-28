using Domain.Entities;
using Domain.Entities.Generics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class MedicineBrandConfiguration : IEntityTypeConfiguration<Medicine_brand>
{
    public void Configure(EntityTypeBuilder<Medicine_brand> builder){
        builder.ToTable("Medicine_brand");
        builder.HasKey(x => x.Id);
        
        // Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Medicine_brand")
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasMaxLength(60)
            .IsRequired();
            
        builder.HasData(
            new{
                Id=1,
                Name = "TQ"
            },
            new{
                Id=2,
                Name = "MK"
            },
            new{
                Id=3,
                Name = "La Sante"
            },
            new{
                Id=4,
                Name = "Durafex"
            },
            new{
                Id=5,
                Name = "Ferrer"
            },
            new{
                Id=6,
                Name = "Bayer"
            },
            new{
                Id=7,
                Name = "Genfar"
            }
        );
    }
}