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
        
        //--Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Presentation")
            .IsRequired();
        
        builder.Property(x => x.Name)
            .HasMaxLength(200)
            .IsRequired();

        // keys

        builder.HasOne(x => x.Medicine_info)
            .WithMany(x => x.Presentations)
            .HasForeignKey(x => x.Id_medicine_info);
    }
    
}