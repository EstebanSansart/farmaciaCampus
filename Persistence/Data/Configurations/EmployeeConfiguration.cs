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

        /*builder.HasOne(y => y.Person)
            .WithOne(y => y.Employee)
            .HasForeignKey(y => y.PersonId);*/
        
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
                    j.ToTable("employee_eps");
                    j.HasKey(t => new{t.EpsId, t.EmployeeId});
                }
            );

    }
    
}
