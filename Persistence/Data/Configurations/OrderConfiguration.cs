using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder){
        builder.ToTable("Order");
        builder.HasKey(x => x.Id);
        
        //--Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Order")
            .IsRequired();
    
        builder.Property(x => x.Order_Date)
            .HasColumnType("DateTime")
            .IsRequired();
        
        builder.Property(x => x.Detail)
            .HasMaxLength(200)
            .IsRequired();
        
        builder.Property(x => x.Date_expiration)
            .HasColumnType("DateTime")
            .IsRequired();

        // keys

        builder.HasOne(x => x.Sale)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.Id_sale);

        builder.HasOne(x => x.Eps)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.EpsId);    

    }
    
}