using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder){
        builder.ToTable("Person");
        builder.HasKey(x => x.Id);
        
        // Properties
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Person")
            .IsRequired();
    
        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasMaxLength(60)
            .IsRequired();

        builder.Property(x => x.Register_date)
            .HasColumnName("Register_Date")
            .HasMaxLength(60)
            .IsRequired();


        builder.Property(x => x.Birth_date)
            .HasColumnName("Birth_Date")
            .HasColumnType("DateTime")
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Document_type)
            .WithMany(x => x.Persons)
            .HasForeignKey(x => x.Id_Document_type);

        builder.HasOne(x => x.Type_Person)
            .WithMany(x => x.Persons)
            .HasForeignKey(x => x.Id_Type_Person);
        
        builder.HasData(
            new{
                Id=1,
                Name = "root",
                Register_date = DateTime.Now,
                Birth_date = DateTime.Now,                
                Id_Type_Person = 1,                
                Id_Document_type = 3,                
                DocumentNumber = "0000000000",                
            },
            new{
                Id=2,
                Name = "ProveedorA",
                Register_date = DateTime.Now,
                Birth_date = DateTime.Now,
                Id_Type_Person = 2,
                Id_Document_type = 3,                
                DocumentNumber = "0000000001",                
            },
            new{
                Id=3,
                Name = "ProveedorB",
                Register_date = DateTime.Now,
                Birth_date = DateTime.Now,
                Id_Type_Person = 2,
                Id_Document_type = 3,                
                DocumentNumber = "0000000002",                
            },
            new{
                Id=4,
                Name = "ProveedorC",
                Register_date = DateTime.Now,
                Birth_date = DateTime.Now,
                Id_Type_Person = 2,
                Id_Document_type = 3,                
                DocumentNumber = "0000000003",                
            },
            new{
                Id=5,
                Name = "Juan Paco",
                Register_date = DateTime.Now,
                Birth_date = new DateTime(2020,1,1),
                Id_Type_Person = 1,
                Id_Document_type = 1,                
                DocumentNumber = "546869433",
            },
            new{
                Id=6,
                Name = "Pedro De La Mar",
                Register_date = new DateTime(2020,1,1),
                Birth_date = new DateTime(1990,1,1),
                Id_Type_Person = 1,
                Id_Document_type = 1,                
                DocumentNumber = "546869433",
            },
            new{
                Id=7,
                Name = "Maria Db",
                Register_date = DateTime.Now,
                Birth_date = new DateTime(2014,7,3),
                Id_Type_Person = 1,
                Id_Document_type = 2,                
                DocumentNumber = "1000354228",
            },
            new{
                Id=8,
                Name = "Ana frank",
                Register_date = new DateTime(2019,05,15),
                Birth_date = new DateTime(1929,7,12),
                Id_Type_Person = 1,
                Id_Document_type = 1,                
                DocumentNumber = "555903923",
            },
            new{
                Id=9,
                Name = "Luis Fonsi",
                Register_date = new DateTime(2018,2,10),
                Birth_date = new DateTime(1978,4,15),
                Id_Type_Person = 1,
                Id_Document_type = 1,                
                DocumentNumber = "123456789",
            },
            new{
                Id=10,
                Name = "Sena Sofia",
                Register_date = new DateTime(2021,3,1),
                Birth_date = new DateTime(1957,12,21),
                Id_Type_Person = 1,
                Id_Document_type = 1,                
                DocumentNumber = "4355466753",
            },
            new{
                Id=11,
                Name = "Elena de avalord",
                Register_date = new DateTime(2001,6,30),
                Birth_date = new DateTime(1987,12,21),
                Id_Type_Person = 1,
                Id_Document_type = 1,                
                DocumentNumber = "74328957843",
            }
        );
    }
    
}
