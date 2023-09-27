using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class CityConfiguAddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder){

        builder.ToTable("Address");
        builder.HasKey(x => x.Id);

         // Properties
         
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Address")
            .IsRequired();

        builder.Property(x => x.Description)
            .HasColumnName("Description")
            .HasMaxLength(200)
            .IsRequired();

        // Keys

        builder.HasOne(x => x.City)
            .WithMany(x => x.Addresses)
            .HasForeignKey(x => x.Id_City);

        builder.HasOne(x => x.Person)
            .WithMany(x => x.Addresses)
            .HasForeignKey(x => x.Id_person);
    }

}