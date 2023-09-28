using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class MedicineInfoConfiguration : IEntityTypeConfiguration<Medicine_info>
{
    public void Configure(EntityTypeBuilder<Medicine_info> builder){
        builder.ToTable("MedicineInfo");
        builder.HasKey(x => x.Id);
        
        // Properties

        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Position")
            .IsRequired();
        
        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasColumnName("Description")
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.Price)
            .HasColumnName("Price")
            .IsRequired();

        builder.Property(x => x.Discount)
            .HasColumnName("Discount")
            .IsRequired();
        
        builder.Property(x => x.Need_order)
            .HasColumnName("Need_Order")
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Presentation)
            .WithMany(x => x.Medicine_Infos)
            .HasForeignKey(x => x.Id_Presentation);

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Medicine_Infos)
            .HasForeignKey(x => x.Id_Category); 

        builder.HasOne(x => x.Medicine_brand)
            .WithMany(x => x.Medicine_Infos)
            .HasForeignKey(x => x.Id_MedicineBrand);
        

        builder.HasData(
            new{
                Id=1,
                Name="Paracetamol",
                Description="Alivia el dolor leve y moderado,\nVia oral 10 comprimidos",
                Image ="https://www.pmfarma.com/noticias/noticias/34179/image/gelocatil%20ferrer%20iqvia%20consumo%20de%20paracetamol%20ha%20aumentado.jpg",
                Price = 20,
                Discount= 0,
                Need_order = true,
                Id_MedicineBrand = 5,
                Id_Presentation = 1,
                Id_Category =1
            },
            new{
                Id=2,
                Name="Ibuprofeno",
                Description="30 tabletas cubiertas de 1g",
                Image ="https://drogueriasantamaria.com/rails/active_storage/representations/proxy/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBOG9nQmc9PSIsImV4cCI6bnVsbCwicHVyIjoiYmxvYl9pZCJ9fQ==--89153d1d91681a39dfe201c944bf3c3f4d47ab2a/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaDdCem9MWm05eWJXRjBTU0lJYW5CbkJqb0dSVlE2RW5KbGMybDZaVjkwYjE5bWFYUmJCMmtDSUFOcEFpQUQiLCJleHAiOm51bGwsInB1ciI6InZhcmlhdGlvbiJ9fQ==--70dc4abb6ac52505d9b5c972f6eb61cd265c8cf9/7702057164157-11.jpg?locale=es",
                Price = 25,
                Discount= 5,
                Need_order = true,
                Id_MedicineBrand = 2,
                Id_Presentation = 1,
                Id_Category =1
            },
            new{
                Id=3,
                Name="Aspirina",
                Description="104 tabletas de 100mg",
                Image ="https://copservir.vtexassets.com/arquivos/ids/1028189/ASPIRINA-100_F.png?v=638292392290900000",
                Price = 15,
                Discount= 10,
                Need_order = true,
                Id_MedicineBrand = 5,
                Id_Presentation = 1,
                Id_Category =1
            },
            new{
                Id=4,
                Name="Amoxicilina",
                Description="50 capsulas 500mg",
                Image ="https://copservir.vtexassets.com/arquivos/ids/1027177-800-auto?v=638292281540200000&width=800&height=auto&aspect=true",
                Price = 40,
                Discount= 0,
                Need_order = true,
                Id_MedicineBrand = 3,
                Id_Presentation = 3,
                Id_Category =1
            },
            new{
                Id=5,
                Name="Cetirizina",
                Description="10 tabletas 10mg",
                Image ="https://copservir.vtexassets.com/arquivos/ids/989672-800-auto?v=638243980849430000&width=800&height=auto&aspect=true",
                Price = 10,
                Discount= 0,
                Need_order = true,
                Id_MedicineBrand = 7,
                Id_Presentation = 1,
                Id_Category =1
            },
            new{
                Id=6,
                Name="Losartan",
                Description="30 tabletas recubiertas de 50mg via oral",
                Image ="https://pasteurio.vtexassets.com/arquivos/ids/174364/Salud-y-Medicamentos-Medicamentos-formulados_Genfar_Pasteur_134452_caja_01.jpg?v=638031144709070000",
                Price = 55,
                Discount= 0,
                Need_order = true,
                Id_MedicineBrand = 7,
                Id_Presentation = 1,
                Id_Category =1
            },
            new{
                Id=7,
                Name="Metformina",
                Description="30 tabletas de 850mg",
                Image ="https://pymstatic.com/43895/conversions/metformina-wide.jpg",
                Price = 60,
                Discount= 40,
                Need_order = true,
                Id_MedicineBrand = 2,
                Id_Presentation = 1,
                Id_Category =1
            },
            new{
                Id=8,
                Name="Atorvastatina",
                Description="30 tabletas recubiertas de 30mg",
                Image ="https://www.farmalisto.com.co/154365/atorvastatina-10-mg-la-sante-caja-con-30-tabletas.jpg",
                Price = 45,
                Discount= 12,
                Need_order = true,
                Id_MedicineBrand = 3,
                Id_Presentation = 1,
                Id_Category =1
            },
            new{
                Id=9,
                Name="Clonazepam",
                Description="30 tabletas recubiertas de 2mg",
                Image ="https://farmastore.com.ve/192-large_default/sedatril-clonazepam-tq-2-mg-x-30-tabletas-rivotril.jpg",
                Price = 35,
                Discount= 0,
                Need_order = true,
                Id_MedicineBrand = 1,
                Id_Presentation = 1,
                Id_Category =1
            },
            new{
                Id=10,
                Name="Loratadina",
                Description="5 mg / 5ml jarabe de 100ml",
                Image ="https://www.drogueriasanjorge.com/wp-content/uploads/2012/03/7702605101641_A1N1_es_s01.jpg",
                Price = 22,
                Discount= 0,
                Need_order = true,
                Id_MedicineBrand = 7,
                Id_Presentation = 2,
                Id_Category =2
            }

        );  
    }   
}