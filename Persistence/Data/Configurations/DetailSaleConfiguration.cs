using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class DetailSaleConfiguration : IEntityTypeConfiguration<Detail_sale>
{
    public void Configure(EntityTypeBuilder<Detail_sale> builder){
        builder.ToTable("Detail_sale");
        builder.HasKey(x => x.Id);
        
        // Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Detail_sale")
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Medicine)
            .WithMany(x => x.Detail_Sales)
            .HasForeignKey(x => x.Id_medicine); 
        
        builder.HasOne(x => x.Sale)
            .WithMany(x => x.Detail_Sales)
            .HasForeignKey(x => x.Id_sale); 

         

    }
    
}
