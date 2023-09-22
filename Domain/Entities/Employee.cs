using Domain.Entities.Generics;

namespace Domain.Entities;

public class Employee : BaseEntityA
{
    public int Id_esp {get;set;}
  
    public int Id_person {get;set;}
    ICollection<Person> People {get;set;}

    public Charge Charge {get;set;}

    public ICollection<Sale> Sales {get;set;}
    public ICollection<Buy> Buys {get;set;}
    public ICollection<Employee_eps> Employee_Epss {get;set;}
    
    
    
}
