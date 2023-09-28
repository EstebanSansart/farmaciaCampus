using System.IO.Compression;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Category");
        builder.HasKey(x => x.Id);

        // Properties
        
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_category")
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasMaxLength(60)
            .IsRequired();
        
        builder.HasData(
            new Category { Id = 1, Name = "A" },
            new Category { Id = 2, Name = "B" },
            new Category { Id = 3, Name = "C" },
            new Category { Id = 4, Name = "D" }

        );


    }
} 