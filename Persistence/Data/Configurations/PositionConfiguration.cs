using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class PositionConfiguration : IEntityTypeConfiguration<Position>
{
    public void Configure(EntityTypeBuilder<Position> builder){
        builder.ToTable("Position");
        builder.HasKey(x => x.Id);
        
        // Properties

        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Position")
            .IsRequired();
        
        builder.Property(x => x.Name)
            .HasMaxLength(60)
            .IsRequired();

        builder.HasData(
            new{
                Id=1,
                Name = "seller"
            },
            new{
                Id=2,
                Name = "manager"
            },
            new{
                Id=3,
                Name = "Administrator"
            }
        );
    }   
}