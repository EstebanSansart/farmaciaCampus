using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class MedicineInfoConfiguration : IEntityTypeConfiguration<Medicine_info>
{
    public void Configure(EntityTypeBuilder<Medicine_info> builder){
        builder.ToTable("MedicineInfo");
        builder.HasKey(x => x.Id);
        
        // Properties

        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Position")
            .IsRequired();
        
        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasColumnName("Description")
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.Price)
            .HasColumnName("Price")
            .IsRequired();

        builder.Property(x => x.Discount)
            .HasColumnName("Discount")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(x => x.Need_order)
            .HasColumnName("Need_Order")
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Presentation)
            .WithMany(x => x.Medicine_Infos)
            .HasForeignKey(x => x.Id_Presentation);

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Medicine_Infos)
            .HasForeignKey(x => x.Id_Category); 

        builder.HasOne(x => x.Medicine_brand)
            .WithMany(x => x.Medicine_Infos)
            .HasForeignKey(x => x.Id_MedicineBrand);
    }   
}