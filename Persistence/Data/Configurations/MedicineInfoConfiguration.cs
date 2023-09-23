using Domain.Entities;
using Domain.Entities.Generics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class MedicineInfoConfiguration : IEntityTypeConfiguration<Medicine_info>
{
    public void Configure(EntityTypeBuilder<Medicine_info> builder){
        builder.ToTable("Medicine_info");
        builder.HasKey(x => x.Id);
        
        // Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Medicine_info")
            .IsRequired();
    
        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasMaxLength(60)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasColumnName("Description")
            .HasMaxLength(60)
            .IsRequired();


        builder.Property(x => x.Price)
            .HasColumnName("Price")
            .HasColumnType("Int")
            .IsRequired();

        builder.Property(x => x.Discount)
            .HasColumnName("Discount")
            .HasColumnType("Bool")
            .IsRequired();
        
        builder.Property(x => x.Id_medicine_name)
            .HasColumnName("Id_medicine_name")
            .HasColumnType("Int")
            .IsRequired();
    

        // Keys

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Medicine_infos)
            .HasForeignKey(x => x.Id_category);

        builder.HasOne(x => x.Presentation)
            .WithMany(x => x.Medicine_infos)
            .HasForeignKey(x => x.PresentationId);
        
        builder.HasOne(x => x.Medicine_brand)
            .WithMany(x => x.Medicine_infos)
            .HasForeignKey(x => X.Id_medicine_brand);      

    }
    
}
*/