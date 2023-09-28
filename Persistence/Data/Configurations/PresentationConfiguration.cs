using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class PresentationConfiguration : IEntityTypeConfiguration<Presentation>
{
    public void Configure(EntityTypeBuilder<Presentation> builder){
        builder.ToTable("Presentation");
        builder.HasKey(x => x.Id);
        
        // Properties
        
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Presentation")
            .IsRequired();
        
        builder.Property(x => x.Name)
            .HasMaxLength(200)
            .IsRequired();

              builder.HasData(
            new Presentation { Id = 1, Name = "Tableta" },
            new Presentation { Id = 2, Name = "Cápsula" },
            new Presentation { Id = 3, Name = "Jarabe" }
        );
    }
}