using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;
public class RolConfiguration : IEntityTypeConfiguration<Rol>{
    public void Configure(EntityTypeBuilder<Rol> builder){
        builder.ToTable("rol");
        builder.HasKey(x => x.Id);
        
        // Properties
        builder.Property(x => x.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");
        
        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("descriptionRole")
            .HasMaxLength(100);                                
    }
}