using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class TypeProviderConfiguration : IEntityTypeConfiguration<Type_provider> {
    public void Configure(EntityTypeBuilder<Type_provider> builder) {
        builder.ToTable("Type_provider");
        builder.HasKey(p => p.Id);

        // Properties

        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_type_provider");

        builder.Property(p => p.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasMaxLength(50);
    }
}