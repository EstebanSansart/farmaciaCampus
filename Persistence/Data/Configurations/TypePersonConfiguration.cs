using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class TypePersonConfiguration : IEntityTypeConfiguration<Type_person>
    {
        public void Configure(EntityTypeBuilder<Type_person> builder)
        {
            builder.ToTable("Type_person");
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_type_person")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Description)
            .HasColumnName("description")
            .IsRequired()
            .HasMaxLength(50);
        }
    }

}