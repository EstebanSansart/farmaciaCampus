using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class EpsConfiguration : IEntityTypeConfiguration<Eps>
{
    public void Configure(EntityTypeBuilder<Eps> builder){
        builder.ToTable("Eps");
        builder.HasKey(x => x.Id);
        
        // Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Eps")
            .IsRequired();
    
        // Keys
        builder.HasOne(x => x.Type_Eps)
            .WithMany(x => x.Epss)
            .HasForeignKey(x => x.Id_type_eps); 

       
            
        
        
    
        

    }
    
}
