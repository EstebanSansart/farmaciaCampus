using System.IO.Compression;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class BuyConfiguration : IEntityTypeConfiguration<Buy>
{
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
            .WithMany(x => x.Buys   )
            .HasForeignKey(x => x.Provider_Id);

        builder.HasOne(x => x.Employee)
            .WithMany(x => x.Buys)
            .HasForeignKey(x => x.Employee_Id);
    }
} 