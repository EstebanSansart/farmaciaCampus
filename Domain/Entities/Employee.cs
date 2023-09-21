using Domain.Entities.Generics;

namespace Domain.Entities;

public class Employee : BaseEntityA
{
    public int Id_esp {get;set;}
  
    public int Id_person {get;set;}
    ICollection<Person> People {get;set;}

    public Charge Charge {get;set;}

    ICollection<Sale> Sales {get;set;}
    ICollection<Buy> Buys {get;set;}
    ICollection<Employee_eps> Employee_Epss {get;set;}
    
    
    
}
