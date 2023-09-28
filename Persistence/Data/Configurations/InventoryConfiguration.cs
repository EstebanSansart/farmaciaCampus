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

        builder.Property(x => x.Total_stock)
            .HasColumnName("Total_Stock")
            .HasColumnType("int")
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Medicine_info)
            .WithMany(x => x.Inventories)
            .HasForeignKey(x => x.Id_MedicineInfo); 
        
        builder.HasData(
            new{
                Id =1,
                Location = "A001",
                Id_MedicineInfo = 1,
                Total_stock=5,
                Ubication=4
            },
            new{
                Id =2,
                Location = "A002",
                Id_MedicineInfo = 2,
                Total_stock=6,
                Ubication=4
            },
            new{
                Id =3,
                Location = "C051",
                Id_MedicineInfo = 3,
                Total_stock=9,
                Ubication=4
            },
            new{
                Id =4,
                Location = "D221",
                Id_MedicineInfo = 4,
                Total_stock=6,
                Ubication=4
            },
            new{
                Id =5,
                Location = "Q011",
                Id_MedicineInfo = 5,
                Total_stock=3,
                 Ubication=4
            },
            new{
                Id =6,
                Location = "C102",
                Id_MedicineInfo = 6,
                Total_stock=4,
                Ubication=4
            },
            new{
                Id =7,
                Location = "C101",
                Id_MedicineInfo = 7,
                Total_stock=7,
                Ubication=4
            },
            new{
                Id =8,
                Location = "D048",
                Id_MedicineInfo = 8,
                Total_stock=8,
                Ubication=4
            },
            new{
                Id =9,
                Location = "H048",
                Id_MedicineInfo = 9,
                Total_stock=2,
                Ubication=4
            },
            new{
                Id =10,
                Location = "H051",
                Id_MedicineInfo = 10,
                Total_stock=4,
                Ubication=4
            }
        );
    }
}
