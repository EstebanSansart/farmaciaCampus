using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class DetailBuyConfiguration : IEntityTypeConfiguration<Detail_buy>
{
    public void Configure(EntityTypeBuilder<Detail_buy> builder){
        builder.ToTable("Detail_buy");
        builder.HasKey(x => x.Id);
        
        // Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Detail_buy")
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Medicine)
            .WithMany(x => x.Detail_Buys)
            .HasForeignKey(x => x.MedicineId);  

        builder.HasOne(x => x.Buy)
            .WithMany(x => x.Detail_Buys)
            .HasForeignKey(x => x.Buy_Id);

    }
    
}
