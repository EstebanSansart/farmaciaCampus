using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
{
    public void Configure(EntityTypeBuilder<Inventory> builder){
        builder.ToTable("Inventory");
        builder.HasKey(x => x.Id);
        
        // Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Inventory")
            .IsRequired();

        builder.Property(x => x.Ubication)
            .HasColumnName("Ubication")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(x => x.Stock_total)
            .HasColumnName("Stock_total")
            .HasColumnType("int")
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Medicine_info)
            .WithMany(x => x.Inventories)
            .HasForeignKey(x => x.MedicineId); 


    }
    
}
