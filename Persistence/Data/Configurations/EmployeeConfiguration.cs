using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder){
        builder.ToTable("Employee");
        builder.HasKey(x => x.Id);
        
        // Properties

        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Employee")
            .IsRequired();

        // Keys

        builder.HasOne(x => x.Position)
            .WithMany(x => x.Employees)
            .HasForeignKey(x => x.PositionId);

        builder.HasOne(x => x.Person)
            .WithMany(x => x.Employees)
            .HasForeignKey(x => x.PersonId); 
        
        // Employee - Eps
    
        builder
            .HasMany(r => r.Epss)
            .WithMany(p => p.Employees)
            .UsingEntity<Employee_eps>(

                j => j
                .HasOne(pt => pt.Eps)
                .WithMany(t => t.Employee_Epss)
                .HasForeignKey(ut => ut.EpsId),

                j => j
                .HasOne(et => et.Employee)
                .WithMany(e => e.Employee_Epss)
                .HasForeignKey(te => te.EmployeeId),

                j =>
                {
                    j.ToTable("Employee_Eps");
                    j.HasKey(t => new{t.EpsId, t.EmployeeId});
                }
            );
            builder.HasData(
            new{
                Id=1,                
                PositionId = 1,
                PersonId = 6
            },
            new{
                Id=2,
                PositionId = 1,
                PersonId = 8
            },
            new{
                Id=3,
                PositionId = 2,
                PersonId = 9
            },
            new{
                Id=4,
                PositionId = 3,
                PersonId = 10
            }
         );
    }   
}