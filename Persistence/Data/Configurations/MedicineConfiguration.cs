using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
{
    public void Configure(EntityTypeBuilder<Medicine> builder){
        builder.ToTable("Medicine");
        builder.HasKey(x => x.Id);
        
        // Properties
        
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Medicine")
            .IsRequired();

        builder.Property(x => x.Date_creation)
            .HasColumnName("Date_creation")
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(x => x.Date_expiration)
            .HasColumnName("Date_expiration")
            .HasColumnType("DateTime")
            .IsRequired();
        
        // Keys

        builder.HasOne(x => x.Inventory)
            .WithMany(x => x.Medicines)
            .HasForeignKey(x => x.Id_Inventory); 
        
        builder.HasOne(x => x.State)
            .WithMany(x => x.Medicines)
            .HasForeignKey(x => x.Id_state); 
              
        builder.HasData(MedicineGenerator(200));
    }

    private static List<Medicine> MedicineGenerator(int NumberOfMedicines){
        var data = new List<Medicine>();
        Random random = new();
        for (int i = 0; i < NumberOfMedicines; i++){
            var medicine = new Medicine{
                Id = i + 1,
                Date_creation = new DateTime(2023,03,2).AddDays(random.Next(1,365)),
                Date_expiration = new DateTime(2025,12,2).AddDays(random.Next(1,365)),
                Id_Inventory = random.Next(1,10),
                Id_state = random.Next(1,5)
            };      
            data.Add(medicine);
        }
        return data;
    }
}