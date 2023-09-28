using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class StateConfiguration : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable("State");
        builder.HasKey(x => x.Id);

        // Properties

        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_State")
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasMaxLength(60)
            .IsRequired();
        
        builder.HasData(
            new{
                Id = 1,
                Description = "default",
                Name="prueba"
            },
            new{
                Id = 2,
                Description = "expired",
                Name="prueba"
            },
            new{
                Id = 3,
                Description = "damaged",
                Name="prueba"
            },
            new{
                Id = 4,
                Description = "Sold",
                Name="prueba"
            },
            new{
                Id = 5,
                Description = "Returned",
                Name="prueba"
            }
        );
    }
}