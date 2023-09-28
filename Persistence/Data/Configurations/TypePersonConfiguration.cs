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
            builder.HasKey(p => p.Id);

            // Properties

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_type_person")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnName("Description")
                .IsRequired()
                .HasMaxLength(50);
            
            builder.HasData(
                new{
                    Id =1,
                    Description = "Natural"
                },
                new{
                    Id = 2,
                    Description = "Juridica"
                }
            );
        }
    }

}