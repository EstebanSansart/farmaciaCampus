using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
{
    public void Configure(EntityTypeBuilder<Provider> builder){
        builder.ToTable("Provider");
        builder.HasKey(x => x.Id);
        
        // Properties

        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Provider")
            .IsRequired();
        
        builder.Property(x => x.Name)
            .HasMaxLength(200)
            .IsRequired();
        
        // Keys

        builder.HasOne(x => x.Type_Provider)
            .WithMany(x => x.Providers)
            .HasForeignKey(x => x.ProviderTypeId);

        builder.HasOne(x => x.Person)
            .WithMany(x => x.Providers)
            .HasForeignKey(x => x.PersonId);
        
        builder.HasData(
            new{
                Id = 1,
                PersonId = 2,
                ProviderTypeId = 1,
                Name="melissa"
            },
            new{
                Id = 2,
                PersonId = 3,
                ProviderTypeId = 2,
                Name="benito"
            },
            new{
                Id = 3,
                PersonId = 4,
                ProviderTypeId = 3,
                Name="MQ society"
            }            
        );
    }
}