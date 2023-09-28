using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class TypeEpsConfiguration : IEntityTypeConfiguration<Type_eps>{
    public void Configure(EntityTypeBuilder<Type_eps> builder){
        builder.ToTable("Type_eps");
        builder.HasKey(p => p.Id);

        // Properties

        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_type_eps");
        
        builder.Property(p => p.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasMaxLength(50);


             builder.HasData(
              
                new Type_eps
                {
                    Id = 1,
                    Name = "Salud Total"
                },
                new Type_eps
                {
                    Id = 2,
                    Name = "Sura"
                }
            );
    }
}