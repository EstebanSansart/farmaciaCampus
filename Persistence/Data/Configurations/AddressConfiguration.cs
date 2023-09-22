using System.IO.Compression;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;
public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("addresses");
        builder.HasKey(x => x.Id);

        //--Properties
        builder.Property(x => x.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("description")
            .HasMaxLength(50);

      


        builder.HasOne(x => x.Person)
        .WithMany(x => x.Addresses)
        .HasForeignKey(x => x.Id_person);


        builder.HasOne(x => x.City)
        .WithMany(x => x.Addresses)
        .HasForeignKey(x => x.Id_City);
    }
}