using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ToTable("Sale");
        builder.HasKey(x => x.Id);

        //--Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Sale")
            .IsRequired();

        builder.Property(x => x.Fecha_venta)
            .HasColumnName("Fecha_venta")
            .HasColumnType("Datetime")
            .IsRequired();

        builder.HasOne(x => x.Employee)
       .WithMany(x => x.Sales)
        .HasForeignKey(x => x.Id_Employe);

    }

}