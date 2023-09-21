using Domain.Entities.Generics;

namespace Domain.Entities;

public class Sale : BaseEntityA
{
    public DateTime Fecha_venta {get;set;}
    public int Id_person {get;set;}

    public Employee Employee {get;set;}
    
    ICollection<Order> Orders {get;set;}
    ICollection<Person> People {get;set;}
    ICollection<Detail_sale> Detail_Sales {get;set;}
   
    
}
