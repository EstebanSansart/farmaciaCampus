using Domain.Entities.Generics;

namespace Domain.Entities;

public class Sale : BaseEntityA
{
    public DateTime Fecha_venta {get;set;}
    public int Id_person {get;set;}

    public int Id_Employe {get;set;}
    public Employee Employee {get;set;}
    
    public ICollection<Order> Orders {get;set;}
    public ICollection<Person> People {get;set;}
    public ICollection<Detail_sale> Detail_Sales {get;set;}
   
    
}
