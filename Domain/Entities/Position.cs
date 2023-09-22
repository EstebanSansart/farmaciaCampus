using Domain.Entities.Generics;

namespace Domain.Entities;

public class Position: BaseEntityA
{
    public string Name {get;set;}
    
    public ICollection<Employee> Employees {get;set;}
}
