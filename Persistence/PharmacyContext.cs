using System.Reflection;
using Domain.Entities;
using Domain.Entities.Generics;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class PharmacyContex: DbContext{
    public PharmacyContex(DbContextOptions<PharmacyContex> conf):base(conf){}


    //-Dbset
    public DbSet<Type_person> Type_People {get;set;}
    public DbSet<Type_eps> Type_Eps {get;set;}
    public DbSet<State> States {get;set;}
    public DbSet<Sale> Sales {get;set;}
    public DbSet<Role_user> Role_Users {get;set;}
    public DbSet<Presentation> Presentations {get;set;}
    public DbSet<Post> Posts {get;set;}
    public DbSet<Person> People {get;set;}
    public DbSet<Order> Orders {get;set;}
    public DbSet<Medicine_info> Medicine_Infos {get;set;}
    public DbSet<Medicine_brand> Medicine_Brands {get;set;}
    public DbSet<Medicine> Medicines {get;set;}
    public DbSet<Inventory> Inventories {get;set;}
    public DbSet<Eps> Epss {get;set;}
    public DbSet<Employee> Employees {get;set;}
    public DbSet<Document_type> Document_Types {get;set;}
    public DbSet<Detail_buy> Detail_Buys {get;set;}
    public DbSet<Departament> Departaments {get;set;}
    public DbSet<Country> Countries {get;set;}
    public DbSet<Contact> Contacts {get;set;}
    public DbSet<Contact_category> Contact_Categories {get;set;}
    public DbSet<Address> Addresses {get;set;}
    public DbSet<City> Cities {get;set;}
    public DbSet<Category> Categories {get;set;}
    public DbSet<Buy> Buys {get;set;}
    public DbSet<Rol> Roles { get; set; }
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