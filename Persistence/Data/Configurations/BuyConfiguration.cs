using System.IO.Compression;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class BuyConfiguration : IEntityTypeConfiguration<Buy>
{
    private static readonly Random _random = new();
    public void Configure(EntityTypeBuilder<Buy> builder)
    {
        builder.ToTable("Buy");
        builder.HasKey(x => x.Id);

        // Properties

        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_buy")
            .IsRequired();

        builder.Property(x => x.BuyDate)
            .HasColumnName("Buy_date")
            .HasColumnType("DateTime")
            .IsRequired();
            
        // Keys

        builder.HasOne(x => x.Provider)
            .WithMany(x => x.Buys)
            .HasForeignKey(x => x.Provider_Id);

        builder.HasOne(x => x.Employee)
            .WithMany(x => x.Buys)
            .HasForeignKey(x => x.Employee_Id);

        // Buy - Medicine

        builder
            .HasMany(r => r.Medicines)
            .WithMany(p => p.Buys)
            .UsingEntity<Detail_buy>(

            j => j
            .HasOne(pt => pt.Medicine)
            .WithMany(t => t.Detail_Buys)
            .HasForeignKey(ut => ut.MedicineId),

            j => j
            .HasOne(et => et.Buy)
            .WithMany(e => e.Detail_Buys)
            .HasForeignKey(te => te.Buy_Id),

            j =>
            {
                j.ToTable("Detail_Buy");
                j.HasKey(t => new{t.MedicineId, t.Buy_Id});
                j.HasData(GetDetailbuyListSeed());
            }
        );

        builder.HasData(
            GetBuySeed()
        );

    }
    private static List<Buy> GetBuySeed(){
        List<Buy> BuysList = new();
        for (int i = 1; i <= 16; i++){
            BuysList.Add(new Buy{
                Id = i,
                BuyDate = new DateTime(2023,05,05).AddDays(_random.Next(1,365)),
                Employee_Id = _random.Next(1,4),
                Provider_Id = _random.Next(1,3)
            });

        }
        return BuysList;    
    }

    private static HashSet<Detail_buy> GetDetailbuyListSeed(){
        HashSet<Detail_buy> Details_buyList = new();
        for (int i = 1; i < 100; i++){
            Details_buyList.Add(new Detail_buy{                                    
                MedicineId = i + 100,
                Buy_Id = _random.Next(1,16)
            });
        }
        return Details_buyList;
    }

} 