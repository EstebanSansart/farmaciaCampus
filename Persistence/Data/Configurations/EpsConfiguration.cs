using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class EpsConfiguration : IEntityTypeConfiguration<Eps>
{
    public void Configure(EntityTypeBuilder<Eps> builder){
        builder.ToTable("Eps");
        builder.HasKey(x => x.Id);
        
        // Properties

        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Eps")
            .IsRequired();
    
        // Keys

        builder.HasOne(x => x.Type_Eps)
            .WithMany(x => x.Epss)
            .HasForeignKey(x => x.Id_type_eps); 

        builder.HasOne(x => x.Person)
            .WithMany(x => x.Epss)
            .HasForeignKey(x => x.Id_Person); 


             builder.HasData(
                
                new Eps
                {
                    Id = 1,
                    Id_type_eps = 1,
                    Id_Person = 1
                },
                new Eps
                {
                    Id = 2,
                    Id_type_eps = 2,
                    Id_Person = 2
                }
            );
    }
    
}
