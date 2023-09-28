using System.IO.Compression;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder){
        builder.ToTable("user");
        builder.HasKey(x => x.Id);

        // Properties
        
        builder.Property(x => x.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");
        
        builder.Property(x => x.UserName)
            .IsRequired()
            .HasColumnName("Username")
            .HasMaxLength(50);
        
        builder.Property(x => x.Email)            
            .HasColumnName("Email")
            .HasMaxLength(100);
        
        builder.Property(x => x.Password)
            .IsRequired()
            .HasColumnName("Password")
            .HasMaxLength(200);

        builder.Property(x => x.AccessToken)
            .HasColumnName("AccessToken")
            .HasMaxLength(500);
        
        builder.Property(x => x.RefreshToken)
            .HasColumnName("RefreshToken")
            .HasMaxLength(500);
        
        builder.HasIndex(p => new{
            p.UserName,p.Email
        })
        .HasDatabaseName("IX_Username_Email")
        .IsUnique();

        // Keys

        builder.HasOne(x => x.Person)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.PersonId); 
        
        // Role - User

         builder
        .HasMany(p => p.Roles)
        .WithMany(r => r.Users)
        .UsingEntity<Role_user>(

           j => j
           .HasOne(pt => pt.Role)
           .WithMany(t => t.Role_Users)
           .HasForeignKey(ut => ut.Id_role),


           j => j
           .HasOne(et => et.User)
           .WithMany(et => et.Role_users)
           .HasForeignKey(el => el.Id_user),

           j =>
           {
                j.ToTable("RoleUser");
               j.HasKey(t => new { t.Id_user, t.Id_role });

        }); 
        builder.HasData(
            new{
                Id = 1,
                UserName = "root",
                Password = "root",
                PersonId = 1
            }
        );
    }
}