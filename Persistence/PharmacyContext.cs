using System.Reflection;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class PharmacyContex: DbContext{
    public PharmacyContex(DbContextOptions<PharmacyContex> conf):base(conf){}


    //-Dbsets
    public DbSet<Rol> Rols { get; set; }
    public DbSet<User> Users { get; set; }
    
    //-Configurations
    protected override void OnModelCreating(ModelBuilder modelBuilder){  


        modelBuilder.Entity<Rol>().HasData(new[]{
            new Rol{
                Id= 1,
                Description = "Administrator"
            },            
            new Rol{
                Id= 2,
                Description = "Manager"
            },
            new Rol{                
                Id= 3,
                Description = "Employee"
            }
        });        


        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}