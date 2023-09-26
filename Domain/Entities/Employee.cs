using Domain.Entities.Generics;

namespace Domain.Entities;

public class Employee : BaseEntityA
{ 
    public int PersonId {get;set;}
    public Person Person {get;set;}
    public int PositionId { get;set; }
    public Position Position {get;set;}

    public ICollection<Sale> Sales {get;set;}
    public ICollection<Buy> Buys {get;set;}
    public ICollection<Eps> Epss {get;set;} = new HashSet<Eps>();
    public ICollection<Employee_eps> Employee_Epss {get;set;} 
}
