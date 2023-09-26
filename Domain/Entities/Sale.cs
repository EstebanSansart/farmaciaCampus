using Domain.Entities.Generics;

namespace Domain.Entities;

public class Sale : BaseEntityA
{
    public DateTime Sale_Date {get;set;}

    public int Id_person {get;set;}
    public Person Person {get;set;}
    public int Id_Employe {get;set;}
    public Employee Employee {get;set;}
    
    public ICollection<Order> Orders {get;set;}
    public ICollection<Medicine> Medicines {get; set;} = new HashSet<Medicine>();
    public ICollection<Detail_sale> Detail_Sales {get;set;}
   
    
}
